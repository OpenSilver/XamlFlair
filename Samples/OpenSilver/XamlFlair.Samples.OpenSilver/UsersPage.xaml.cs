﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Blend.SampleData.SampleUsers;

namespace XamlFlair.Samples.WPF
{
	/// <summary>
	/// Interaction logic for UsersPage.xaml
	/// </summary>
	public partial class UsersPage : Page
	{
		public UsersPage()
		{
			InitializeComponent();
		}

		private void PlacesGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (sender is ListBox lb && lb.SelectedItem is PlacesItem place)
			{
				MainPage.RootFrame.Navigated += new NavigationHelper(place).OnNavigated;
                MainPage.RootFrame.Navigate(new Uri("/XamlFlair.Samples.OpenSilver;component/PlacePage.xaml", UriKind.RelativeOrAbsolute));
            }
        }

		private sealed class NavigationHelper
		{
			private readonly PlacesItem _place;

            public NavigationHelper(PlacesItem place)
			{
				_place = place;
            }

            public void OnNavigated(object sender, NavigationEventArgs e)
            {
				MainPage.RootFrame.Navigated -= OnNavigated;

                ((PlacePage)e.Content).CurrentPlace = _place;
            }
        }
	}
}
