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

        private string mainText;
        public string MainText
        {
            get { return mainText; }
            set
            {
                mainText = value;
                OnPropertyChanged();
            }
        }

        public void MainPageLoaded(object sender, EventArgs e)
        {
        }

        public void OnSomeButtonClicked(object sender, EventArgs e)
        {
            MainText = "FORK YOU";
            xSomeButton.Text = "FORK YOU";
        }
    }
}
