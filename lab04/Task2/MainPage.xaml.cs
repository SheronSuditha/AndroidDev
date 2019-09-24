using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StudentData
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void btnEnterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EnterInformation
            {
                BindingContext = new StudentInfo()
            });
        }
        async void btnShowAllClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowAllInformation { });
        }
    }
}
