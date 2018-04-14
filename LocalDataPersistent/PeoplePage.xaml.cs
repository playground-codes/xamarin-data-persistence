using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LocalDataPersistent
{
    public partial class PeoplePage : ContentPage
    {
        public PeoplePage()
        {
            InitializeComponent();
        }

        async void OnAddPeopleClicked(object sender, EventArgs args)
        {
            statusMessage.Text = string.Empty;
            await App.PeopleRepository.AddNewPerson(newPerson.Text);
            statusMessage.Text = App.PeopleRepository.StatusMessage;
        }

        async void OnGetAllPeopleClicked(object sender, EventArgs args)
        {
            statusMessage.Text = string.Empty;
            var people = await App.PeopleRepository.GetAllPeople();
            peopleList.ItemsSource = people;
        }
    }
}
