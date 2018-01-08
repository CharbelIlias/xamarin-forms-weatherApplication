using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace NetStatus
{
	public partial class App : Application
	{
		public App ()
		{
            InitializeComponent();

            MainPage = new NetStatus.MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=b27810bc-a8da-487a-85eb-b0bbc61425fc;",
                   typeof(Analytics), typeof(Crashes));
        }
        protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
