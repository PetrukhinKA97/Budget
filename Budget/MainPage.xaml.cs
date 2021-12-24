using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Budget
{
    public partial class MainPage : Shell
    {
        int count = 0;
     
        public MainPage()
        {
            InitializeComponent();
        }
        void Button_Clicked(object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
        }

    }
}
