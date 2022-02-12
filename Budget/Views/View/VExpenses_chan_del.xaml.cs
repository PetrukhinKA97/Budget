using Budget.Views.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Budget.Views.ViewModel;

namespace Budget.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VExpenses_chan_del : ContentPage
    {

        public VExpenses_chan_del()
        {
            InitializeComponent();
            ExpensesV.ItemsSource= App.Database.Update();
        }

        private void Delete(object sender, EventArgs e)
        {

        }

        private void Change(object sender, EventArgs e)
        {

        }
    }
}