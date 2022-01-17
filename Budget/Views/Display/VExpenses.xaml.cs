using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Budget.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class expenses : ContentPage
    {

        public expenses()
        {
            InitializeComponent();
        }
        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            switch (picker.SelectedIndex) 
            {
                case 0:
                    Spending.Text = "Тип расходов";
                    break;
                case 1:
                    Spending.Text = "Тип доходов";
                    break;
            }
            if (selectedIndex != -1)
            {
                //WOW.Text = picker.Items[selectedIndex];
            }
        }
    }
}