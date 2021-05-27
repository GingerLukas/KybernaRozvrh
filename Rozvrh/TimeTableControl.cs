using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Rozvrh.API;

namespace Rozvrh
{
    public partial class TimeTableControl : UserControl
    {
        [Browsable(true)] public int UserId { get; set; } = 10470;
        private DateTime _date = DateTime.Now;
        public DateTime Date
        {
            get { return _date;}
            set
            {
                _date = value.AddDays(1 - (int) _date.DayOfWeek);
                UpdateTimeTable();
            }
        }
        private Color[] _colors = new Color[] {Color.Orange, Color.DarkOrange,};
        private TimeTableDay[] _timeTable = new TimeTableDay[5];

        private List<CellControl>[] _cellControls = new List<CellControl>[5]
        {
            new List<CellControl>(), new List<CellControl>(), new List<CellControl>(), new List<CellControl>(),
            new List<CellControl>()
        };

        public TimeTableControl()
        {
            InitializeComponent();
            UpdateTimeTable();
        }

        private void UpdateTimeTable()
        {
            for (int i = 0; i < 5; i++)
            {
                _timeTable[i] = TimeTableManager.GetTimeTable(UserId, _date.AddDays(i));
            }
            UpdateTimeTableControls();
            
        }

        private void UpdateTimeTableControls()
        {
            int column = Width / 5;

            foreach (var day in _cellControls)
            {
                foreach (CellControl control in day)
                {
                    this.Controls.Remove(control);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                var day = _timeTable[i];
                foreach (CellsItem cell in day.Cells)
                {
                    CellControl control = new CellControl() {CellsItem = cell};
                    _cellControls[i].Add(control);
                    Controls.Add(control);
                }
            }
            UpdateTimeTableControlsLayout();
        }

        private void UpdateTimeTableControlsLayout()
        {
            int column = Width / 5;
            for (int i = 0; i < 5; i++)
            {
                foreach (CellControl control in _cellControls[i])
                {
                    control.Size = new Size(column,control.Size.Height);
                    control.Location = new Point(column * i, (int)(((control.CellsItem.StartTime.TimeOfDay.TotalHours) - 7) *
                                                             (control.Size.Height + 10)));
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int column = Width / 5;


            for (int i = 0; i < 5; i++)
            {
                Color color = _colors[i % _colors.Length];
                g.FillRectangle(new SolidBrush(color), i * column, 0, column, Height);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            Invalidate();
            UpdateTimeTableControlsLayout();
            base.OnResize(e);
        }

        private void _btnPrev_Click(object sender, EventArgs e)
        {
            Date = Date.AddDays(-7);
        }

        private void _btnNext_Click(object sender, EventArgs e)
        {
            Date = Date.AddDays(7);
        }

        private void _numberId_ValueChanged(object sender, EventArgs e)
        {
            UserId = (int) _numberId.Value;
            Date = Date;
        }
    }
}
