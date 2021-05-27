
namespace Rozvrh
{
    partial class TimeTableControl
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
            this._btnNext = new System.Windows.Forms.Button();
            this._numberId = new System.Windows.Forms.NumericUpDown();
            this._btnPrev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._numberId)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnNext
            // 
            this._btnNext.Location = new System.Drawing.Point(100, 2);
            this._btnNext.Name = "_btnNext";
            this._btnNext.Size = new System.Drawing.Size(94, 29);
            this._btnNext.TabIndex = 0;
            this._btnNext.Text = ">";
            this._btnNext.UseVisualStyleBackColor = true;
            this._btnNext.Click += new System.EventHandler(this._btnNext_Click);
            // 
            // _numberId
            // 
            this._numberId.Location = new System.Drawing.Point(200, 2);
            this._numberId.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this._numberId.Name = "_numberId";
            this._numberId.Size = new System.Drawing.Size(150, 27);
            this._numberId.TabIndex = 1;
            this._numberId.Value = new decimal(new int[] {
            10470,
            0,
            0,
            0});
            this._numberId.ValueChanged += new System.EventHandler(this._numberId_ValueChanged);
            // 
            // _btnPrev
            // 
            this._btnPrev.Location = new System.Drawing.Point(0, 2);
            this._btnPrev.Name = "_btnPrev";
            this._btnPrev.Size = new System.Drawing.Size(94, 29);
            this._btnPrev.TabIndex = 2;
            this._btnPrev.Text = "<";
            this._btnPrev.UseVisualStyleBackColor = true;
            this._btnPrev.Click += new System.EventHandler(this._btnPrev_Click);
            // 
            // TimeTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._btnPrev);
            this.Controls.Add(this._numberId);
            this.Controls.Add(this._btnNext);
            this.Name = "TimeTableControl";
            this.Size = new System.Drawing.Size(861, 431);
            ((System.ComponentModel.ISupportInitialize)(this._numberId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnNext;
        private System.Windows.Forms.NumericUpDown _numberId;
        private System.Windows.Forms.Button _btnPrev;
    }
}
