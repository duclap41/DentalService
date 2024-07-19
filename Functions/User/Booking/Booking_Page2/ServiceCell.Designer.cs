namespace DentalService.Booking.Booking_Page2
{
    partial class ServiceCell
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
            this.cPnCell = new DentalService.CustomPanel();
            this.lbPnCell = new System.Windows.Forms.Label();
            this.cPnCell.SuspendLayout();
            this.SuspendLayout();
            // 
            // cPnCell
            // 
            this.cPnCell.BackColor = System.Drawing.Color.White;
            this.cPnCell.BackgroundColor = System.Drawing.Color.White;
            this.cPnCell.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cPnCell.BorderRadius = 25;
            this.cPnCell.BorderSize = 3;
            this.cPnCell.Controls.Add(this.lbPnCell);
            this.cPnCell.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cPnCell.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.cPnCell.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.cPnCell.Location = new System.Drawing.Point(0, 0);
            this.cPnCell.Name = "cPnCell";
            this.cPnCell.Size = new System.Drawing.Size(420, 55);
            this.cPnCell.TabIndex = 0;
            this.cPnCell.UseGradient = false;
            // 
            // lbPnCell
            // 
            this.lbPnCell.BackColor = System.Drawing.Color.Transparent;
            this.lbPnCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPnCell.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPnCell.Location = new System.Drawing.Point(0, 0);
            this.lbPnCell.Name = "lbPnCell";
            this.lbPnCell.Size = new System.Drawing.Size(420, 55);
            this.lbPnCell.TabIndex = 1;
            this.lbPnCell.Text = "Niềng răng mắc cài kim loại";
            this.lbPnCell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPnCell.Click += new System.EventHandler(this.lbPnCell_Click);
            // 
            // ServiceCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cPnCell);
            this.Name = "ServiceCell";
            this.Size = new System.Drawing.Size(420, 55);
            this.cPnCell.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel cPnCell;
        private System.Windows.Forms.Label lbPnCell;
    }
}
