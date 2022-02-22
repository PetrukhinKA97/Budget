using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Budget;
using ViewModel;
using System.Collections.ObjectModel;
using Model;
using System.Collections.Generic;

namespace View.Budget
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VExpenses : ContentPage
    {

        public VExpenses()
        {
            InitializeComponent();
            BindingView();
            
        }

        private async void Delete(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Xamarin.Forms.MenuItem))
            {
                var ff = (Model.MExpenses)((Xamarin.Forms.MenuItem)sender).BindingContext;
                await App.Database.DeleteItemAsync(ff);
                App.Database.ListMS.Remove(ff);
            }
        }

        private  async void BindingView()
        {
            await App.Database.GetItems();
            ExpensesV.ItemsSource =  App.Database.ListMS;
            ExpensesV.BindingContext = App.Database.ListMS;
        }

        private async void Change(object sender, EventArgs e)
        {
            //Открытие формы VExpenses_add_chan с выбранными данными
            MExpenses ff = (MExpenses)((MenuItem)sender).BindingContext;
            await Navigation.PushAsync(new VExpenses_add_chan(ff));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //Открытие формы VExpenses_add_chan
            await Navigation.PushAsync(new VExpenses_add_chan());
        }
    }
}