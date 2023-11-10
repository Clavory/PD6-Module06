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
public partial class GeolocationPage : ContentPage
{
    bool isGettingLocation;
    public GeolocationPage()
    {
        InitializeComponent();
    }

    async void Start_Locate(System.Object sender, System.EventArgs e)
    {
        isGettingLocation = true;
        while(isGettingLocation)
        {
                var result = await GeolocationPage.GetLocationAsync
                    (new GeolocationRequest(GeolocationAccuracy.Default, TimeSpan.FromMinutes(1)));
                resultLocation.Text += $"Lat: {result.Latitude}, lng: {result.Longitude} {Environment.NewLine}";
        }
    }

    private void Stop_Locate(System.Object sender, System.EventArgs e)
    {
            IsGettingLocation = false;
    }
}
}