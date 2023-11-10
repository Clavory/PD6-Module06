using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PD6_Module06
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class DeviceBatteryPage : ContentPage
{
    public DeviceBatteryPage()
    {
        InitializeComponent();
        SetBackground(Battery.ChargeLevel, Battery.State == BatteryState.Charging);
    }

    void setBackground(double level, bool charging)
    {
        Color? color = null;
        var status = charging ? "Charging" : "Not Charging";
        if (level > 0.5f)
        {
            color = Color.Green.MultiplyAlpha(level);
        }
        if (level > .1)
        {
            color = Color.DarkOrange.MultiplyAlpha(level);
        }

        else
        {
            color = Color.Red.MultiplyAlpha(level);
        }

        BackgroundColor = color.Value;
        LabelBatteryLevel.Text = status; 

    }
    void Battery_BatteryInfoChanged(object sender, EventArgs e)
    {
            setBackground(e.ChargeLevel, e.state == BatteryState.Charging);
    }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }


    }
}