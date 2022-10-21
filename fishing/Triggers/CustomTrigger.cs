using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace fishing.Triggers
{
    public class CustomTrigger : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            double result;
            bool isValid = Double.TryParse(sender.Text, out result);
            sender.TextColor = isValid ? Color.Red : Color.Green;
        }
    }
}
