namespace DentalService.Service
{
    partial class ServiceList
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
            this.fLPnDropList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // fLPnDropList
            // 
            this.fLPnDropList.BackColor = System.Drawing.Color.Transparent;
            this.fLPnDropList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPnDropList.Location = new System.Drawing.Point(0, 0);
            this.fLPnDropList.Margin = new System.Windows.Forms.Padding(0);
            this.fLPnDropList.Name = "fLPnDropList";
            this.fLPnDropList.Size = new System.Drawing.Size(330, 194);
            this.fLPnDropList.TabIndex = 0;
            // 
            // ServiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.fLPnDropList);
            this.Name = "ServiceList";
            this.Size = new System.Drawing.Size(330, 194);
            this.MouseLeave += new System.EventHandler(this.ServiceList_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLPnDropList;
    }
}
