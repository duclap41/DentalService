namespace DentalService.Booking.Booking_Page3
{
    partial class DoctorCell
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
            this.cTbLPnCell = new DentalService.CustomTableLayoutPanel();
            this.cPicAvatar = new DentalService.CustomPictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbMajor = new System.Windows.Forms.Label();
            this.cTbLPnCell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPicAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // cTbLPnCell
            // 
            this.cTbLPnCell.BackColor = System.Drawing.Color.White;
            this.cTbLPnCell.BackgroundColor = System.Drawing.Color.White;
            this.cTbLPnCell.BorderColor = System.Drawing.Color.Black;
            this.cTbLPnCell.BorderRadius = 10;
            this.cTbLPnCell.BorderSize = 3;
            this.cTbLPnCell.ColumnCount = 2;
            this.cTbLPnCell.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.cTbLPnCell.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cTbLPnCell.Controls.Add(this.cPicAvatar, 0, 0);
            this.cTbLPnCell.Controls.Add(this.lbName, 1, 0);
            this.cTbLPnCell.Controls.Add(this.lbMajor, 1, 1);
            this.cTbLPnCell.ForeColor = System.Drawing.Color.Black;
            this.cTbLPnCell.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.cTbLPnCell.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.cTbLPnCell.Location = new System.Drawing.Point(0, 0);
            this.cTbLPnCell.Name = "cTbLPnCell";
            this.cTbLPnCell.RowCount = 2;
            this.cTbLPnCell.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.cTbLPnCell.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.cTbLPnCell.Size = new System.Drawing.Size(435, 80);
            this.cTbLPnCell.TabIndex = 0;
            this.cTbLPnCell.UseGradient = false;
            // 
            // cPicAvatar
            // 
            this.cPicAvatar.BackColor = System.Drawing.Color.Transparent;
            this.cPicAvatar.BackgroundColor = System.Drawing.Color.Transparent;
            this.cPicAvatar.BorderColor = System.Drawing.Color.Black;
            this.cPicAvatar.BorderRadius = 35;
            this.cPicAvatar.BorderSize = 1;
            this.cPicAvatar.ForeColor = System.Drawing.Color.Black;
            this.cPicAvatar.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.cPicAvatar.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.cPicAvatar.Image = global::DentalService.Properties.Resources.doctor_male;
            this.cPicAvatar.Location = new System.Drawing.Point(15, 5);
            this.cPicAvatar.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.cPicAvatar.Name = "cPicAvatar";
            this.cTbLPnCell.SetRowSpan(this.cPicAvatar, 2);
            this.cPicAvatar.Size = new System.Drawing.Size(70, 70);
            this.cPicAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cPicAvatar.TabIndex = 0;
            this.cPicAvatar.TabStop = false;
            this.cPicAvatar.UseGradient = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbName.Font = new System.Drawing.Font("PT Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(105, 5);
            this.lbName.Margin = new System.Windows.Forms.Padding(5);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(256, 38);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Dr. Graham Shadwick, DDS";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMajor
            // 
            this.lbMajor.AutoSize = true;
            this.lbMajor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMajor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMajor.Location = new System.Drawing.Point(105, 53);
            this.lbMajor.Margin = new System.Windows.Forms.Padding(5);
            this.lbMajor.Name = "lbMajor";
            this.lbMajor.Size = new System.Drawing.Size(52, 22);
            this.lbMajor.TabIndex = 1;
            this.lbMajor.Text = "Bác sĩ";
            // 
            // DoctorCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cTbLPnCell);
            this.Name = "DoctorCell";
            this.Size = new System.Drawing.Size(435, 80);
            this.Load += new System.EventHandler(this.DoctorCell_Load);
            this.cTbLPnCell.ResumeLayout(false);
            this.cTbLPnCell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPicAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTableLayoutPanel cTbLPnCell;
        private CustomPictureBox cPicAvatar;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMajor;
    }
}
