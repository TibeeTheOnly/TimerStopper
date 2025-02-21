using System;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TimerStopper
{
    /// <summary>
    /// Interaction logic for TimerWindow.xaml
    /// </summary>
    public partial class TimerWindow : Window
    {
        //DispatcherTimer az időzítéshez
        private DispatcherTimer Timer;

        //Hátralévő idő
        private TimeSpan RemainingTime;

        public TimerWindow()
        {
            InitializeComponent();

            //Timer init, 1 másodperces frissítéssel
            Timer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            //Timer tixk esemény (másodpercenként hívódik)
            Timer.Tick += Timer_Tick;
        }

        //Minden tick (1 másodperc) során csökkentjük a hátralévő időt
        private void Timer_Tick(object sender, EventArgs e)
        {
            //Ha van hátralévő idő
            if(RemainingTime.TotalSeconds > 0)
            {
                //Csökkentjük 1 másodperccel
                RemainingTime = RemainingTime.Subtract(TimeSpan.FromSeconds(1));
                //Frissítjük a megjelenítést
                UpdateDisplay();
            }
            else
            {
                //Ha lejárt az idő, leállítjuk a timert
                Timer.Stop();
                //Értesítés
                MessageBox.Show("Neked kicsöngettek öcskös!");
            }
        }

        //A megjelenítés frissítése
        private void UpdateDisplay()
        {
            //A hátralévő időt megjelenítjük a label-en
            txtTimer.Text = RemainingTime.ToString(@"hh\:mm\:ss");
        }

        private void SetTimer(object sender, RoutedEventArgs e)
        {
            try
            {
                //Felhasználó által megadott idő beállítása
                string input = TimerInput.Text;
                if (int.TryParse(input, out int seconds))
                {
                    RemainingTime = TimeSpan.FromSeconds(seconds);
                }
                else
                {
                    RemainingTime = TimeSpan.Parse(input);
                }

                //idő kiírása
                txtTimer.Text = RemainingTime.ToString(@"hh\:mm\:ss");
            }
            catch
            {
                MessageBox.Show("Érvénytelen időformátum! (HH:MM:SS)", "hiba");
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if(RemainingTime.TotalSeconds > 0)
            {
                Timer.Start();
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            RemainingTime = TimeSpan.Zero;
            txtTimer.Text = "00:00:00";
        }


    }
}
