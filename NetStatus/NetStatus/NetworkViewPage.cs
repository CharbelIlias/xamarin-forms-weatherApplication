using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NetStatus
{
	public class NetworkViewPage : ContentPage
	{
        Label ConnectionDetails;

        public NetworkViewPage ()
		{
            var layout = new StackLayout { Padding = new Thickness(5, 10) };
            this.Content = layout;
            ConnectionDetails = new Label { Text = "ConnectionDetails" };
            layout.Children.Add(ConnectionDetails);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (CrossConnectivity.Current == null)
                return;

            ConnectionDetails.Text = CrossConnectivity.Current.ConnectionTypes.First().ToString();

            CrossConnectivity.Current.ConnectivityChanged += UpdateNetworkInfo;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            if (CrossConnectivity.Current != null)
                CrossConnectivity.Current.ConnectivityChanged -= UpdateNetworkInfo;
        }

        private void UpdateNetworkInfo(object sender, ConnectivityChangedEventArgs e)
        {
            if (CrossConnectivity.Current != null && CrossConnectivity.Current.ConnectionTypes != null)
            {
                var connectionType = CrossConnectivity.Current.ConnectionTypes.FirstOrDefault();
                ConnectionDetails.Text = connectionType.ToString();
            }
        }
    }
}