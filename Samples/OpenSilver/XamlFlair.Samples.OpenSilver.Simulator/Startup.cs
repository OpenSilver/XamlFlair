using OpenSilver.Simulator;
using System;
using XamlFlair.Samples.WPF;

namespace XamlFlair.Samples.OpenSilver.Simulator
{
    internal static class Startup
    {
        [STAThread]
        static int Main(string[] args)
        {
            return SimulatorLauncher.Start(typeof(App));
        }
    }
}
