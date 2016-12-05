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

        private void IncrementButton_Clicked(object sender, EventArgs e)
        {
            m_count++;
            CountLabel.Text = "COUNT = " + m_count;
        }
    }
}
