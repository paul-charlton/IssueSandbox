using IssueSandbox.Views.Issues;
using Xamarin.Forms;

namespace IssueSandbox
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CollectionViewLosingItems();
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }
    }
}