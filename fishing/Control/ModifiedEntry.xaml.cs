using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fishing.Control
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModifiedEntry : ContentView
    {
        public ModifiedEntry()
        {
            InitializeComponent();
            entryBox.Text = Text;
            titleTxt.Text = Title;
            entryBox.IsPassword = IsPassword;
            entryBox.TextChanged += OnTextChanged;
        }

      

        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), 
                                                                              typeof(ModifiedEntry), default(string));
        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string),
                                                                                           typeof(ModifiedEntry), default(string),
                                                                                             BindingMode.TwoWay);
       public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create(nameof(IsPassword), typeof(bool), typeof(ModifiedEntry),
                                                                                              default(bool), BindingMode.TwoWay);
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public bool IsPassword
        {
            get => (bool)GetValue(IsPasswordProperty);
            set => SetValue(IsPasswordProperty, value);
        }
        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }
            set
            {
                SetValue(TitleProperty, value);
            }
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == TitleProperty.PropertyName)
            {
                titleTxt.Text = Title;
            }
            if (propertyName == TextProperty.PropertyName)
            {
                entryBox.Text = Text;
            }
            if (propertyName == IsPasswordProperty.PropertyName)
            {
                entryBox.IsPassword = IsPassword;
            }
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Text = e.NewTextValue;
        }
    }
}