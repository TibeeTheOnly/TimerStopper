using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
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

namespace TimerStopper
{
    /// <summary>
    /// Interaction logic for StopperWindow.xaml
    /// </summary>
    public partial class StopperWindow : Window
    {
        private DispatcherTimer StopperTimer;

        private TimeSpan ElapsedTime;

        public StopperWindow()
        {
            InitializeComponent();

            ElapsedTime = TimeSpan.Zero;

            StopperTimer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromMilliseconds(1)
            };

            StopperTimer.Tick += StopperTimer_Tick;
        }

        private void StopperTimer_Tick(object? sender, EventArgs e)
        {
            //eltelt idő növelése 1000ms-el
            ElapsedTime = ElapsedTime.Add(TimeSpan.FromMilliseconds(1000));

            //megjelenítés frissítése
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            StopperDisplay.Text = ElapsedTime.ToString();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            StopperTimer.Start();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            StopperTimer.Stop();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            StopperTimer.Stop();
            ElapsedTime = TimeSpan.Zero;
            UpdateDisplay();
        }
    }
}
