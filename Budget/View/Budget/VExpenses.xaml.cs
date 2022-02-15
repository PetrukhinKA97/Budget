using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Budget;

namespace View.Budget
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VExpenses : ContentPage
    {

        public VExpenses()
        {
            InitializeComponent();
            ExpensesV.ItemsSource = App.Database.Update();
        }

        private void Delete(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Xamarin.Forms.MenuItem))
            {
                App.database.Delete(((Xamarin.Forms.MenuItem)sender).BindingContext);
            }
        }

        private void Change(object sender, EventArgs e)
        {
            //Открытие формы VExpenses_add_chan с выбранными данными

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //Открытие формы VExpenses_add_chan
            await Navigation.PushAsync(new VExpenses_add_chan());
        }
    }
}