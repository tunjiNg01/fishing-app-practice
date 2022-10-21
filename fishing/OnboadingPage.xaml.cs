using fishing.ViewModel;
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
    public partial class OnboadingPage : ContentPage
    {
        public OnboadingPage()
        {
            InitializeComponent();
            BindingContext = new OnboardingViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           await Fader.FadeTo(1, 1000);
           await Navigation.PopModalAsync(false);

        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            radiaGradient.RadiusX = width * 3.77;
        }

      
    }
}