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

        void OnAddPeopleClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            App.PeopleRepository.AddNewPerson(newPerson.Text);
            statusMessage.Text = App.PeopleRepository.StatusMessage;
        }

        void OnGetAllPeopleClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            List<Person> people = App.PeopleRepository.GetAllPeople();
            peopleList.ItemsSource = people;
        }
    }
}
