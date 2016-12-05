using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsLoading
{
    public partial class MainPage : ContentPage
    {
        private int m_count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void IncrementButton_Clicked(object sender, EventArgs e)
        {
            using (UserDialogs.Instance.Loading("doing..."))
            {
                await Task.Delay(1000);
                m_count++;
                CountLabel.Text = "COUNT = " + m_count;
                await Task.Delay(1000);
            }
        }

    }
}
