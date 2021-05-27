
namespace Rozvrh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timeTableControl1 = new Rozvrh.TimeTableControl();
            this.SuspendLayout();
            // 
            // timeTableControl1
            // 
            this.timeTableControl1.Date = new System.DateTime(2021, 5, 26, 11, 54, 47, 112);
            this.timeTableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeTableControl1.Location = new System.Drawing.Point(0, 0);
            this.timeTableControl1.Name = "timeTableControl1";
            this.timeTableControl1.Size = new System.Drawing.Size(800, 450);
            this.timeTableControl1.TabIndex = 0;
            this.timeTableControl1.UserId = 10470;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeTableControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TimeTableControl timeTableControl1;
    }
}

