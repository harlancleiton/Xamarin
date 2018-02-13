using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NovosComponentes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RangePage : ContentPage
    {
        public RangePage()
        {
            InitializeComponent();
        }

        public void OnSliderValueChanged(object sender, ValueChangedEventArgs eventArgs)
        {
            LblSlider.Text = eventArgs.NewValue.ToString();
        }
        public void OnStepperValueChanged(object sender, ValueChangedEventArgs eventArgs)
        {
            LblStepper.Text = eventArgs.NewValue.ToString();
        }
    }
}