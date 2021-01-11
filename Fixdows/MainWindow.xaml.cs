using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Fixdows
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void AboutRedirButtonGithub_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/terrific-tea/Fixdows");
        }

        private void AboutRedirButtonDiscord_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://terrific-tea.github.io/links/discord");
        }

        private void AboutRedirButtonMyEmail_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("mailto:alej0hio2007@gmail.com");
        }

        private void CleanDiskButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("cleanmgr");
        }

        private void EverythingLabel_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://voidtools.com");
        }

        private void WDSLabel_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://windirstat.net");
        }

        private void IntegrityFixButton_click(object sender, RoutedEventArgs e)
        {
            var dir = Directory.GetCurrentDirectory(); // Get current directory before actual code, and assign it to a variable ( I can probably optimize this )
            if (dir.Contains("Debug")) // Does the current Directory have "debug" in it? if so, do this.
            {
                Directory.SetCurrentDirectory("../");
                Directory.SetCurrentDirectory("../");
            }

            dir = Directory.GetCurrentDirectory(); // assign current directory to variable
            Console.WriteLine(dir); // For debugging
            var integrity = new ProcessStartInfo($"{dir}/assets/integrity.bat");
            integrity.Verb = "runas"; // Just to make sure that we launch as administrator
            Process.Start(integrity); // Now we run the integrity check script
        }

        private void WupdButton_Click(object sender, RoutedEventArgs e)
        {
            var dir = Directory.GetCurrentDirectory(); // Get current directory before actual code, and assign it to a variable ( I can probably optimize this )
            if (dir.Contains("Debug")) // Does the current Directory have "debug" in it? if so, do this.
            {
                Directory.SetCurrentDirectory("../");
                Directory.SetCurrentDirectory("../");
            }

            dir = Directory.GetCurrentDirectory(); // assign current directory to variable
            Console.WriteLine(dir); // For debugging
            var wu = new ProcessStartInfo($"{dir}/assets/wu.bat");
            wu.Verb = "runas"; // Just to make sure that we launch as administrator
            Process.Start(wu); // Now we run the integrity check script
        }
    }
}
