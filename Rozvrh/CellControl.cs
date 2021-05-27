using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Rozvrh.API;

namespace Rozvrh
{
    public partial class CellControl : UserControl
    {
        private CellsItem _cellsItem;
        public CellsItem CellsItem
        {
            get { return _cellsItem;}
            set
            {
                _cellsItem = value;
                UpdateUi();
            }
        }
        public CellControl()
        {
            InitializeComponent();
        }

        private void UpdateUi()
        {
            _lblTeacher.Text = CellsItem.Teacher;
            _lblSubject.Text = CellsItem.Subject;
            _lblClassRoom.Text = CellsItem.ClassRoom;
            _lblTime.Text = CellsItem.StartTime.ToString("hh-mm") +" - "+ CellsItem.StartTime.AddMinutes(45).ToString("hh-mm");
        }

        protected override void OnClick(EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CellsItem.MeetUrl))
            {
                return;
            }
            //Process.Start(CellsItem.MeetUrl);
            base.OnClick(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            _lblSubject.Location = new Point(Width-_lblSubject.Size.Width,0);
            _lblTime.Location = new Point(Width-_lblTime.Size.Width,_lblSubject.Location.Y+_lblSubject.Height);
            _lblClassRoom.Location = new Point(Width-_lblClassRoom.Size.Width, _lblTime.Location.Y + _lblTime.Height);
            _lblTeacher.Location = new Point(0,Height-_lblTeacher.Size.Height);
        }
    }
}
