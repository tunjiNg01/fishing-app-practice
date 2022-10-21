using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace fishing
{
    public partial class MainPage : ContentPage
    {
        Page onboardingPage;
        public MainPage()
        {
            InitializeComponent();

            if (FirstAppLaunch() == true)
            {

                App.Current.ModalPopping += Current_ModalPopping;
                onboardingPage = new OnboadingPage();
                Navigation.PushModalAsync(onboardingPage, false);
            }
        }

        private async void Current_ModalPopping(object sender, ModalPoppingEventArgs e)
        {
            if (e.Modal == onboardingPage)
            {
                 await  Fader.FadeTo(0, 1000);
                onboardingPage = null;
                App.Current.ModalPopping -= Current_ModalPopping;

            }
        }

        private bool FirstAppLaunch()
        {
            if (VersionTracking.IsFirstLaunchEver)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
