using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity2 : ContentPage
    {
        public activity2()
        {
            InitializeComponent();
        }

        void OnSliderValueChanged (object sender, ValueChangedEventArgs args)
        {
            var value = args.NewValue.ToString("0");
            valueLabel.Text = String.Format("Rate how much you like Xamarin : {0}", value);

        }


         async void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            await DisplayAlert("Xamarin Trivia", "Did you know that Xamarin was named after tamarin monkeys? So if you ever wondered, why the mascot of Xamarin is a monkey, here is your answer!", "Now, I know");
        }

    }
}