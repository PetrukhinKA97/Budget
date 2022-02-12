using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Budget.Views.Model;
using Budget.Views.ViewModel;
using SQLite;

namespace Budget.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VExpenses_add : ContentPage
    {

        public VExpenses_add()
        {
            InitializeComponent();
            this.BindingContext = new MExpenses();
        }

        // обработка нажатия кнопки добавления
        private  void Importance_add_Clicked(object sender, EventArgs e)
        {
            MExpenses wow = (MExpenses)this.BindingContext;
            App.Database.SaveItem(wow);
        }
    }
}