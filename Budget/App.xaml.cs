using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Budget.Views.Service;
using System.IO;
using Budget.Views.ViewModel;

namespace Budget
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "Budget.db";
        public static VMExpenses database;
        public static VMExpenses Database
        {
            get
            {
                if (database == null)
                {
                    database = new VMExpenses(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }   
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
