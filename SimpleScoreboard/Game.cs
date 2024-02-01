using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace SimpleScoreboard
{
    public class Game
    {
        public int ScoreTeam1 { get; set; }
        public int ScoreTeam2 { get; set; }

        readonly DispatcherTimer _gameTimer = new DispatcherTimer();
        public DateTime GameTime { get; set; } = new DateTime(2024, 01, 26, 0, 12, 0);
        private DateTime _gameTimeSet = new DateTime(2024, 01, 26, 0, 12, 0);

        public Game()
        {
            _gameTimer.Tick += GameTimerTick;
            _gameTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
        }

        public void TimerStart()
        {
            _gameTimer.Start(); 
        }


        public void GameTimerTick(object? sender, EventArgs e)
        {
            GameTime = GameTime.Subtract(TimeSpan.FromSeconds(1));

            if (GameTime.Minute == 0 && GameTime.Second == 0)
            {
                _gameTimer.Stop();
            }
        }

        public void TimerReset()
        {
            _gameTimer.Stop();
            GameTime = _gameTimeSet;

            ScoreTeam1 = 0;
            ScoreTeam2 = 0;
        }

        public void TimerPause()
        {
            _gameTimer.Stop(); 
        }

        public void MinInc()
        {
            if (_gameTimeSet.Minute < 59)
            {
                _gameTimeSet = _gameTimeSet.AddMinutes(1);
                GameTime = _gameTimeSet;
            }
        }

        public void MinDec()
        { if (_gameTimeSet.Minute > 1)
            {
                _gameTimeSet = _gameTimeSet.Subtract(TimeSpan.FromMinutes(1));
                GameTime = _gameTimeSet;
            }
        }

        public int ScoreTeam1Inc()
        {
            if (ScoreTeam1 < 98)
            {
                ScoreTeam1++;
            }
            return ScoreTeam1;
        }

        public int ScoreTeam2Inc()
        {
            if (ScoreTeam2 < 98)
            {
                ScoreTeam2++;
            }
            return ScoreTeam2;
        }

        public int ScoreTeam1Dec()
        {
            if (ScoreTeam1 > 0)
            {
                ScoreTeam1--;
            }
            return ScoreTeam1;
        }

        public int ScoreTeam2Dec()
        {
            if (ScoreTeam2 > 0)
            {
                ScoreTeam2--;
            }
            return ScoreTeam2;
        }
    }
}
