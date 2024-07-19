namespace DentalService.Service
{
    partial class ServiceName
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
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(210, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Niềng răng mắc cài kim loại";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            this.lbName.MouseEnter += new System.EventHandler(this.lbName_MouseEnter);
            this.lbName.MouseLeave += new System.EventHandler(this.lbName_MouseLeave);
            // 
            // ServiceName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.Name = "ServiceName";
            this.Size = new System.Drawing.Size(210, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
    }
}
