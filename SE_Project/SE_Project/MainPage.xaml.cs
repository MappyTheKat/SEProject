using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SE_Project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); //<- 대체 왜??
        }

        string MainText;

        public void OnSomeButtonClicked(object sender, EventArgs e)
        {
            MainText = "FORK YOU";
        }
    }
}
