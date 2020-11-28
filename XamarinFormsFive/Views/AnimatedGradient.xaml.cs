using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsFive.Views
{
    public partial class AnimatedGradient : ContentPage
    {
        public AnimatedGradient()
        {
            InitializeComponent();
            Task.Run(AnimatedBackground);
        }

        private async void AnimatedBackground()
        {
            Action<double> fordward = input => bvGradient.AnchorY = input;
            Action<double> backward = input => bvGradient.AnchorY = input;
            while (true)
            {
                bvGradient.Animate(name: "fordward", callback: fordward, start: 0, end: 1, length: 5000, easing: Easing.SinInOut);
                await Task.Delay(4000);
                bvGradient.Animate(name: "backward", callback: backward, start: 1, end: 0, length: 5000, easing: Easing.SinInOut);
                await Task.Delay(4000);
            }
        }
    }
}
