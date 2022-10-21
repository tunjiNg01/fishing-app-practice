using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fishing
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TriggerTut : ContentPage
    {
        public TriggerTut()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }


        private async void isfocusentry_Focused(object sender, FocusEventArgs e)
        {

            if (isfocusentry.Focus())
            {
                var onboardingPage = new OnboadingPage();
               await Navigation.PushModalAsync(onboardingPage, true);

            }
        }
    }
}