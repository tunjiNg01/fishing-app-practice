using fishing.Model;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace fishing.ViewModel
{
    class OnboardingViewModel :BaseViewModel
    {
        private ObservableRangeCollection<OnboardingModel> _item;

        public ObservableRangeCollection<OnboardingModel> Item { get => _item; set => SetProperty(ref _item, value); }

        public OnboardingViewModel()
        {
            Item = new ObservableRangeCollection<OnboardingModel>
                {
                    new OnboardingModel
                    {
                        Title = "Discover nature and catch The fish",
                        Description = "simply dummy text of the printing " +
                        "and typesetting industry. Lorem Ipsum has been the industry's " +
                        "standard dummy text ever since the 1500s, when an unknown printer took a galle",
                        Image = "",
                    },

                     new OnboardingModel
                    {
                        Title = "Discover nature and catch The fish",
                        Description = "simply dummy text of the printing " +
                        "and typesetting industry. Lorem Ipsum has been the industry's " +
                        "standard dummy text ever since the 1500s, when an unknown printer took a galle",
                        Image = "",
                    },

                      new OnboardingModel
                    {
                        Title = "Discover nature and catch The fish",
                        Description = "simply dummy text of the printing " +
                        "and typesetting industry. Lorem Ipsum has been the industry's " +
                        "standard dummy text ever since the 1500s, when an unknown printer took a galle",
                        Image = "",
                    },
                };
        }
    }
}
