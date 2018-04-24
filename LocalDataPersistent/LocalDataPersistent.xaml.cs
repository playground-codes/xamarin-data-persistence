using System;
using Xamarin.Forms;

namespace LocalDataPersistent
{
    public partial class MainPage : ContentPage
    {

        PreferenceHelper preferenceHelper;
        public MainPage()
        {
            InitializeComponent();
            PopulateSettings();

        }

        void PopulateSettings()
        {
            preferenceHelper = new PreferenceHelper();
            nameEntry.Text = preferenceHelper.Name;
            ageEntry.Text = preferenceHelper.Age.ToString();
            emailEntry.Text = preferenceHelper.Email;
        }

        void OnUpdateSettings(object sender, EventArgs e)
        {
            preferenceHelper.Name = nameEntry.Text;
            preferenceHelper.Age = int.Parse(ageEntry.Text);
            preferenceHelper.Email = emailEntry.Text;
        }

        async void OnGoToPeoplePage(object sender, EventArgs e)
        {
            PeoplePage peoplePage = new PeoplePage();
            await Navigation.PushAsync(peoplePage);
        }
    }
}
