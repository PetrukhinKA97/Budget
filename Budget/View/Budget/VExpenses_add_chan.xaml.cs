using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Budget;
using Model;

namespace View.Budget
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VExpenses_add_chan : ContentPage
    {

        public VExpenses_add_chan()
        {
            InitializeComponent();
            this.BindingContext = new MExpenses();
        }

        // обработка нажатия кнопки добавления
        private async void Importance_add_Clicked(object sender, EventArgs e)
        {
            MExpenses wow = (MExpenses)this.BindingContext;
            App.Database.SaveItem(wow);
            await Navigation.PopAsync();
            App.Database.Update();
        }
    }
}