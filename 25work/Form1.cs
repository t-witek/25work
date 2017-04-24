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
        enum TimerStateEnum { Start, Stop, Pause, Continue, Alarm, Dismiss }
        
        #region properties
        private SoundPlayer alarmSound;
        private DateTime time;
        private CycleEnum cycle;
        private TimerStateEnum timerState;
        private int numberOfCycles = 0;
        private TimeSpan workTime = TimeSpan.Zero;
        private const string remainingTimeString = "Remaining {0} time";
        private const string timeForString = "Time for {0}";
        private const string numberOfCyclesString = "Num. of cycles {0} (total work time {1})";

        private string CycleName
        {
            get
            {
                switch (cycle)
                {
                    case CycleEnum.Break:
                        return "break";
                    case CycleEnum.Work:
                        return "work";
                    default:
                        return null;
                }
                    
            }
        }
        
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
                        cancelButton.Text = "Toggle Cycle";
                        break;
                    case TimerStateEnum.Start:
                        timer1.Start();
                        button1.Text = "Pause";
                        cancelButton.Text = "Stop";
                        break;
                    case TimerStateEnum.Pause:
                        timer1.Stop();
                        button1.Text = "Continue";
                        break;
                    case TimerStateEnum.Continue:
                        timer1.Start();
                        button1.Text = "Pause";
                        break;
                    case TimerStateEnum.Alarm:
                        timer1.Stop();
                        if (cycle == CycleEnum.Work)
                            AddCycle();
                        Activate();
                        alarmSound.PlayLooping();
                        infoLabel.Font = new Font(infoLabel.Font, FontStyle.Bold);
                        infoLabel.Text = string.Format(timeForString, cycle == CycleEnum.Work ? "break" : "work");
                        button1.Text = "Dismiss";
                        break;
                    case TimerStateEnum.Dismiss:
                        alarmSound.Stop();
                        ToggleCycle();
                        infoLabel.Font = new Font(infoLabel.Font, FontStyle.Regular);
                        TimerState = TimerStateEnum.Start;
                        break;
                }
                timerState = value;   
            }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
            cycle = CycleEnum.Break;
            ToggleCycle();
            TimerState = TimerStateEnum.Stop;
            alarmSound = new SoundPlayer(_25work.Properties.Resources.alarm);
            alarmSound.Load();
            UpdateWorkTimeLabel();
        }

        #region methods
        private void ToggleCycle ()
        {
            if (cycle == CycleEnum.Break)
            {
                cycle = CycleEnum.Work;
            }
            else
            {
                cycle = CycleEnum.Break;
            }

            time = Duration;
            infoLabel.Text = string.Format(remainingTimeString, CycleName);
            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            timeLabel.Text = string.Format("{0:00}:{1:00}", time.Minute, time.Second);
        }

        private void AddCycle()
        {
            numberOfCycles++;
            workTime += new TimeSpan(0, Duration.Minute, Duration.Second);
            UpdateWorkTimeLabel();
        }

        private void UpdateWorkTimeLabel()
        {
            numOfCyclesLabel.Text = string.Format(numberOfCyclesString, numberOfCycles, workTime.ToString());
        }
        #endregion

        #region event handlers
        private void button1_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "Start":
                    TimerState = TimerStateEnum.Start;
                    break;
                case "Pause":
                    TimerState = TimerStateEnum.Pause;
                    break;
                case "Continue":
                    TimerState = TimerStateEnum.Continue;
                    break;
                case "Dismiss":
                    TimerState = TimerStateEnum.Dismiss;
                    break;
            }
        }
        
        private void cancelButton_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "Stop":
                    TimerState = TimerStateEnum.Stop;
                    break;
                case "Toggle Cycle":
                    ToggleCycle();
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.AddSeconds(-1);
            UpdateTimeLabel();
            if (time.Minute == 0 && time.Second == 0)
                TimerState = TimerStateEnum.Alarm;
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            if (TimerState == TimerStateEnum.Stop)
            {
                time = Duration;
                UpdateTimeLabel();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            numberOfCycles = 0;
            workTime = TimeSpan.Zero;
            UpdateWorkTimeLabel();
        }
        #endregion

    }
}
