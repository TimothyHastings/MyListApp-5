using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyListApp
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage()
		{
			InitializeComponent();
		}

		void OnButtonClicked(object sender, EventArgs args)
		{
			myLabel.Text = myEntry.Text;
		}

		void OnFocus(object sender, EventArgs args)
		{
		}
	}
}
