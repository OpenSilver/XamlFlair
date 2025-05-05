using System;
using System.Windows;

namespace XamlFlair
{
	public sealed class XamlFlairResources : ResourceDictionary
	{
		public XamlFlairResources()
		{
#if OPENSILVER
            Source = new Uri("/XamlFlair.WPF;component/DefaultAnimations.xaml", UriKind.RelativeOrAbsolute);
			Application.LoadComponent(this, Source);
#else
			Source = new Uri("pack://application:,,,/XamlFlair.WPF;component/DefaultAnimations.xaml");
#endif
        }
    }
}