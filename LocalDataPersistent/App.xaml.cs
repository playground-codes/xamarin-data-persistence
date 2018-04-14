using Xamarin.Forms;

namespace LocalDataPersistent
{
    public partial class App : Application
    {
        public static PeopleRepository PeopleRepository { get; private set; }

        public App(string databaseLocation)
        {
            InitializeComponent();

            PeopleRepository = new PeopleRepository(databaseLocation);

            MainPage page = new MainPage();

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
