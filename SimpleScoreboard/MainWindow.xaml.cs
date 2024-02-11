using System.Windows;
using System.Windows.Threading;
using WpfScreenHelper;

namespace SimpleScoreboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly DispatcherTimer _dispatcherTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            _dispatcherTimer.Tick += DispatcherTimerTick;
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            _dispatcherTimer.Start();

            btnTimerPause.Visibility = Visibility.Hidden;

            btnScoreTeam1Dec.IsEnabled = false;
            btnScoreTeam2Dec.IsEnabled = false;
            btnScoreTeam1Inc.IsEnabled = false;
            btnScoreTeam2Inc.IsEnabled = false;

            btnMinDec.IsEnabled = true;
            btnMinInc.IsEnabled = true;

            VM.Display.Show();

            

        }

        private void DispatcherTimerTick(object sender, EventArgs e)
        {
            var screens = Screen.AllScreens;
            var screencount = 0;

            if (VM.Game.ScoreTeam1 < 9)
            {
                MwScore10Team1.Content = "0";
            }
            else
            {
                MwScore10Team1.Content = VM.Game.ScoreTeam1.ToString("00").Remove(1);
            }

            if (VM.Game.ScoreTeam2 < 9)
            {
                MwScore10Team2.Content = "0";
            }
            else
            {
                MwScore10Team2.Content = VM.Game.ScoreTeam2.ToString("00").Remove(1);
            }

            MwScore1Team1.Content = VM.Game.ScoreTeam1.ToString("00").Remove(0, 1);
            MwScore1Team2.Content = VM.Game.ScoreTeam2.ToString("00").Remove(0, 1);

            MwMinute1.Content = VM.Game.GameTime.Minute.ToString("00").Remove(1);
            MwMinute2.Content = VM.Game.GameTime.Minute.ToString("00").Remove(0, 1);

            MwSecond1.Content = VM.Game.GameTime.Second.ToString("00").Remove(1);
            MwSecond2.Content = VM.Game.GameTime.Second.ToString("00").Remove(0, 1);

            MwScore10Team1.FontSize = MwColumn0.ActualWidth - 10;
            MwScore1Team1.FontSize = MwColumn0.ActualWidth - 10;
            MwScore10Team2.FontSize = MwColumn0.ActualWidth - 10;
            MwScore1Team2.FontSize = MwColumn0.ActualWidth - 10;
            MwMinute1.FontSize = MwColumn0.ActualWidth - 10;
            MwMinute2.FontSize = MwColumn0.ActualWidth - 10;
            MwSecond1.FontSize = MwColumn0.ActualWidth - 10;
            MwSecond2.FontSize = MwColumn0.ActualWidth - 10;
            MwColon.FontSize = MwColumn0.ActualWidth - 10;

            //Set Variabeles for Display
            VM.Display.Score1Team1.Content = MwScore1Team1.Content;
            VM.Display.Score10Team1.Content = MwScore10Team1.Content;
            VM.Display.Score1Team2.Content = MwScore1Team2.Content;
            VM.Display.Score10Team2.Content = MwScore10Team2.Content;

            VM.Display.Minute1.Content = MwMinute1.Content;
            VM.Display.Minute2.Content = MwMinute2.Content;
            VM.Display.Second1.Content = MwSecond1.Content;
            VM.Display.Second2.Content = MwSecond2.Content; 

            VM.Display.Score10Team1.FontSize = VM.Display.Column0.ActualWidth + 100;
            VM.Display.Score1Team1.FontSize = VM.Display.Column0.ActualWidth + 100;
            VM.Display.Score10Team2.FontSize = VM.Display.Column0.ActualWidth + 100;
            VM.Display.Score1Team2.FontSize = VM.Display.Column0.ActualWidth + 100;
            VM.Display.Minute1.FontSize = VM.Display.Column0.ActualWidth + 100;
            VM.Display.Minute2.FontSize = VM.Display.Column0.ActualWidth + 100;
            VM.Display.Second1.FontSize = VM.Display.Column0.ActualWidth + 100;
            VM.Display.Second2.FontSize = VM.Display.Column0.ActualWidth + 100;
            VM.Display.Colon.FontSize = VM.Display.Column0.ActualWidth + 100;

            if(VM.Display.WindowState == WindowState.Maximized)
            {
                VM.Display.WindowStyle = WindowStyle.None;
            }

            if(VM.Game.GameTime.Minute == 0 && VM.Game.GameTime.Second == 0)
            {
                btnTimerPause.IsEnabled = false;
            }

foreach (Screen screen in screens)
            {
                screencount++;
            }
if (screencount  <= 1)
            {
                VM.Display.WindowState = WindowState.Normal;
                VM.Display.WindowStyle = WindowStyle.ToolWindow;
                VM.Display.Width = 1900;
                VM.Display.Height = 800;
            }
         
        }

        private void btnMinInc_Click(object sender, RoutedEventArgs e)
        {
            if (btnMinInc.IsEnabled == true)
            {
                VM.Game.MinInc();
            }
        }

        private void btnMinDec_Click(object sender, RoutedEventArgs e)
        {
            if (btnMinDec.IsEnabled == true)
            {
                VM.Game.MinDec();
            }
        }

        private void btnTimerStart_Click(object sender, RoutedEventArgs e)
        {
            if (btnTimerStart.IsEnabled == true)
            {
                VM.Game.TimerStart();

                btnTimerPause.Visibility = Visibility.Visible;
                btnTimerStart.Visibility = Visibility.Hidden;
                btnScoreTeam1Dec.IsEnabled = true;
                btnScoreTeam2Dec.IsEnabled = true;
                btnScoreTeam1Inc.IsEnabled = true;
                btnScoreTeam2Inc.IsEnabled = true;

                btnTimerPause.IsEnabled = true;
                btnMinDec.IsEnabled = false;
                btnMinInc.IsEnabled = false;
            }
        }

        private void btnTimerReset_Click(object sender, RoutedEventArgs e)
        {
            if (btnTimerReset.IsEnabled == true)
            {
                VM.Game.TimerReset();

                btnScoreTeam1Dec.IsEnabled = false;
                btnScoreTeam2Dec.IsEnabled = false;
                btnScoreTeam1Inc.IsEnabled = false;
                btnScoreTeam2Inc.IsEnabled = false;

                btnMinDec.IsEnabled = true;
                btnMinInc.IsEnabled = true;

                btnTimerPause.IsEnabled = false;
                btnTimerPause.Visibility = Visibility.Hidden;
                btnTimerStart.Visibility = Visibility.Visible;
            }
        }

        private void btnTimerPause_Click(object sender, RoutedEventArgs e)
        {
            if (btnTimerPause.IsEnabled == true)
            {
                VM.Game.TimerPause();

                btnTimerPause.Visibility = Visibility.Hidden;
                btnTimerStart.Visibility = Visibility.Visible;

                btnMinDec.IsEnabled = false;
                btnMinInc.IsEnabled = false;
            }
        }

        private void btnScoreTeam1Inc_Click(object sender, RoutedEventArgs e)
        {
            if (btnScoreTeam1Inc.IsEnabled == true)
            {
                VM.Game.ScoreTeam1Inc();
            }
        }

        private void btnScoreTeam1Dec_Click(object sender, RoutedEventArgs e)
        {
            if (btnScoreTeam1Dec.IsEnabled == true)
            {
                VM.Game.ScoreTeam1Dec();
            }
        }

        private void btnScoreTeam2Inc_Click(object sender, RoutedEventArgs e)
        {
            if (btnScoreTeam2Inc.IsEnabled == true)
            {
                VM.Game.ScoreTeam2Inc();
            }
        }

        private void btnScoreTeam2Dec_Click(object sender, RoutedEventArgs e)
        {
            if (btnScoreTeam2Dec.IsEnabled == true)
            {
                VM.Game.ScoreTeam2Dec();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            VM.Display.Close();
        }
    }
}