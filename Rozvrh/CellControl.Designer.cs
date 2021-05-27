
namespace Rozvrh
{
    partial class CellControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._lblSubject = new System.Windows.Forms.Label();
            this._lblTime = new System.Windows.Forms.Label();
            this._lblTeacher = new System.Windows.Forms.Label();
            this._lblClassRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblSubject
            // 
            this._lblSubject.AutoSize = true;
            this._lblSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblSubject.Location = new System.Drawing.Point(243, 0);
            this._lblSubject.Name = "_lblSubject";
            this._lblSubject.Size = new System.Drawing.Size(56, 28);
            this._lblSubject.TabIndex = 0;
            this._lblSubject.Text = "MAT";
            // 
            // _lblTime
            // 
            this._lblTime.AutoSize = true;
            this._lblTime.Location = new System.Drawing.Point(240, 20);
            this._lblTime.Name = "_lblTime";
            this._lblTime.Size = new System.Drawing.Size(42, 20);
            this._lblTime.TabIndex = 1;
            this._lblTime.Text = "TIME";
            // 
            // _lblTeacher
            // 
            this._lblTeacher.AutoSize = true;
            this._lblTeacher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblTeacher.Location = new System.Drawing.Point(0, 78);
            this._lblTeacher.Name = "_lblTeacher";
            this._lblTeacher.Size = new System.Drawing.Size(85, 23);
            this._lblTeacher.TabIndex = 2;
            this._lblTeacher.Text = "TEACHER";
            // 
            // _lblClassRoom
            // 
            this._lblClassRoom.AutoSize = true;
            this._lblClassRoom.Location = new System.Drawing.Point(187, 40);
            this._lblClassRoom.Name = "_lblClassRoom";
            this._lblClassRoom.Size = new System.Drawing.Size(95, 20);
            this._lblClassRoom.TabIndex = 3;
            this._lblClassRoom.Text = "CLASSROOM";
            // 
            // CellControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblClassRoom);
            this.Controls.Add(this._lblTeacher);
            this.Controls.Add(this._lblTime);
            this.Controls.Add(this._lblSubject);
            this.Name = "CellControl";
            this.Size = new System.Drawing.Size(282, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblSubject;
        private System.Windows.Forms.Label _lblTime;
        private System.Windows.Forms.Label _lblTeacher;
        private System.Windows.Forms.Label _lblClassRoom;
    }
}
