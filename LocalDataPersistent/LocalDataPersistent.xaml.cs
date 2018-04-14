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
            nameEntry.Text = preferenceHelper.GetName();
            ageEntry.Text = preferenceHelper.GetAge().ToString();
            emailEntry.Text = preferenceHelper.GetEmail();
        }

        void OnUpdateSettings(object sender, EventArgs e)
        {
            preferenceHelper.SaveName(nameEntry.Text);
            preferenceHelper.SaveAge(int.Parse(ageEntry.Text));
            preferenceHelper.SaveEmail(emailEntry.Text);
        }

        async void OnGoToPeoplePage(object sender, EventArgs e) {
            PeoplePage peoplePage = new PeoplePage();
            await Navigation.PushAsync(peoplePage);
        }
    }
}
