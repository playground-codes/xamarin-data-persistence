using Xamarin.Forms;

namespace LocalDataPersistent
{
    public partial class App : Application
    {
        public App(string databaseLocation)
        {
            InitializeComponent();

            LocalDataPersistent.MainPage page = new MainPage(){
                databasePath = databaseLocation
            };

            MainPage = new NavigationPage(page);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
