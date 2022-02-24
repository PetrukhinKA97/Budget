using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Budget;
using Model.Budget;

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

        public VExpenses_add_chan(MExpenses expenses)
        {
            InitializeComponent();
            MExpensesView.BindingContext = expenses;
        }

        // обработка нажатия кнопки добавления
        private async void Importance_add_Clicked(object sender, EventArgs e)
        {
            MExpenses wow = (MExpenses)MExpensesView.BindingContext;
            await App.Database.SaveItemAsync(wow);
            await Navigation.PopAsync();
        }
    }
}