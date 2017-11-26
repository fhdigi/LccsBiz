using FreshMvvm;
using LccsBiz.Std.Models;
using LccsBiz.Std.PageModels;
using LccsBiz.Std.Pages;
using Xamarin.Forms;

namespace LccsBiz.Std
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            /* create the navigation container */
            var tabbedNavigation = new FreshTabbedNavigationContainer();

            /* add in the pages for the tabes */
            tabbedNavigation.AddTab<HomePageModel>("Dashboard", null);
            tabbedNavigation.AddTab<AccountsPageModel>("Accounts", null);
            tabbedNavigation.AddTab<ReceivablesPageModel>("Receivables", null);
            tabbedNavigation.AddTab<PayablesPageModel>("Payables", null);
            tabbedNavigation.AddTab<CompanyPageModel>("Company", null);

            /* Set the main page */
            MainPage = tabbedNavigation;
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
