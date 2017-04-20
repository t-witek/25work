using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25work
{
    public partial class Form1 : Form
    {
        enum CycleEnum { Break, Work }
        enum TimerStateEnum { Start, Stop }
        
        #region properties
        private SoundPlayer soundPlayer;
        private DateTime time;
        private CycleEnum cycle;
        private TimerStateEnum timerState;

        //private CycleEnum Cycle
        //{
        //    get;
        //}
        private DateTime Duration
        {
            get
            {
                if (cycle == CycleEnum.Break)
                    return breakTimePicker.Value;
                else
                    return workTimePicker.Value;
            }
        }
        private TimerStateEnum TimerState
        {
            get
            {
                return timerState;
            }
            set
            {
                switch (value) 
                {
                    case TimerStateEnum.Stop:
                        timer1.Stop();
                        time = Duration;
                        UpdateTimeLabel();
                        button1.Text = "Start";
                        break;
                }

                timerState = value;
                    
            }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
            cycle = CycleEnum.Work;
            TimerState = TimerStateEnum.Stop;
            soundPlayer = new SoundPlayer(_25work.Properties.Resources.alarm);
            soundPlayer.Load();
        }

        #region methods
        private void ToggleState ()
        {
            if (cycle == CycleEnum.Break)
                cycle = CycleEnum.Work;
            else
                cycle = CycleEnum.Break;
        }

        private void UpdateTimeLabel()
        {
            timeLabel.Text = string.Format("{0:00}:{1:00}", time.Minute, time.Second);
        }
        #endregion
    }
}
