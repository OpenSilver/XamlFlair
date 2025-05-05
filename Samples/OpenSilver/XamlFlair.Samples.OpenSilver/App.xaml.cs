using Blend.SampleData.SampleUsers;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Windows;
using System.Windows.Controls;

namespace XamlFlair.Samples.WPF
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			LoadResources();

            // Setup the Serilog logger
            Log.Logger = new LoggerConfiguration()
				.MinimumLevel.Debug()
				.WriteTo.Debug()
				.CreateLogger();

			// Initalie the XamlFlair loggers using the LoggerFactory (with Serilog support)
			XamlFlair.Animations.InitializeLoggers(new LoggerFactory().AddSerilog());
        }

		private void LoadResources()
		{
			var xamlFlairResources = new XamlFlairResources();
			Resources.MergedDictionaries.Add(xamlFlairResources);

            var converters = new ResourceDictionary();
			converters.Source = new Uri("/XamlFlair.Samples.OpenSilver;component/Converters.xaml", UriKind.RelativeOrAbsolute);
			LoadComponent(converters, converters.Source);
			Resources.MergedDictionaries.Add(converters);

            var colors = new ResourceDictionary();
            colors.Source = new Uri("/XamlFlair.Samples.OpenSilver;component/Styles/Colors.xaml", UriKind.RelativeOrAbsolute);
            LoadComponent(colors, colors.Source);
            Resources.MergedDictionaries.Add(colors);

            var button = new ResourceDictionary();
            button.Source = new Uri("/XamlFlair.Samples.OpenSilver;component/Styles/Controls/Button.xaml", UriKind.RelativeOrAbsolute);
            LoadComponent(button, button.Source);
            Resources.MergedDictionaries.Add(button);

            var listBoxItem = new ResourceDictionary();
            listBoxItem.Source = new Uri("/XamlFlair.Samples.OpenSilver;component/Styles/Controls/ListBoxItem.xaml", UriKind.RelativeOrAbsolute);
            LoadComponent(listBoxItem, listBoxItem.Source);
            Resources.MergedDictionaries.Add(listBoxItem);

            var listBox = new ResourceDictionary();
            listBox.Source = new Uri("/XamlFlair.Samples.OpenSilver;component/Styles/Controls/ListBox.xaml", UriKind.RelativeOrAbsolute);
            LoadComponent(listBox, listBox.Source);
            Resources.MergedDictionaries.Add(listBox);

            var textblock = new ResourceDictionary();
            textblock.Source = new Uri("/XamlFlair.Samples.OpenSilver;component/Styles/Controls/TextBlock.xaml", UriKind.RelativeOrAbsolute);
            LoadComponent(textblock, textblock.Source);
            Resources.MergedDictionaries.Add(textblock);

			Resources.Add("SampleUsers", new SampleUsers());
        }

        /*
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<!-- Load the default pre-defined animations that exist in the XamlFlair.WPF assembly -->
				<xf:XamlFlairResources />
				
				<ResourceDictionary Source="Converters.xaml" />

				<ResourceDictionary Source="Styles\Colors.xaml" />
				<ResourceDictionary Source="Styles\Controls\Button.xaml" />
				<!-- <ResourceDictionary Source="Styles\Controls\ListViewItem.xaml" /> -->
				<!-- <ResourceDictionary Source="Styles\Controls\ListView.xaml" /> -->
				<ResourceDictionary Source="Styles\Controls\TextBlock.xaml" />
			</ResourceDictionary.MergedDictionaries>

			<SampleUsers:SampleUsers x:Key="SampleUsers"
									 d:IsDataSource="True" />
		</ResourceDictionary>
		*/

        protected override void OnStartup(StartupEventArgs e)
		{
            RootVisual = new MainPage();
        }
	}
}
