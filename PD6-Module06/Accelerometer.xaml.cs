﻿using System;
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
public partial class Accelerometer : ContentPage
{
    public Accelerometer()
    {
        InitializeComponent();
    }
    private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
    {
        LabelX.Text = e.Reading.Acceleration.ToString();
        LabelY.Text = e.Reading.Acceleration.ToString();
        LabelZ.Text = e.Reading.Acceleration.ToString();
    }

    private void ButtonStart_Clicked(object sender, EventArgs e) 
    {
        if (Accelerometer.IsMonitoring)
            return;

        Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
        Accelerometer.Start(SensorSpeed.UI);


                
    }

    private void ButtonStop_Clicked(object sender, EventArgs e)
    {
        if (Accelerometer.IsMonitoring)
            return;

        Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
        Accelerometer.Stop();



    }
}
}