namespace DentalService.Info
{
    partial class InfoList
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbDentist = new System.Windows.Forms.Label();
            this.lbDoctorNurse = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbDentist);
            this.flowLayoutPanel1.Controls.Add(this.lbDoctorNurse);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(154, 200);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbDentist
            // 
            this.lbDentist.AutoSize = true;
            this.lbDentist.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDentist.Location = new System.Drawing.Point(3, 10);
            this.lbDentist.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbDentist.Name = "lbDentist";
            this.lbDentist.Size = new System.Drawing.Size(79, 19);
            this.lbDentist.TabIndex = 0;
            this.lbDentist.Text = "Nha Khoa";
            this.lbDentist.Click += new System.EventHandler(this.lbDentist_Click);
            this.lbDentist.MouseEnter += new System.EventHandler(this.Event_MouseEnter);
            this.lbDentist.MouseLeave += new System.EventHandler(this.Event_MouseLeave);
            // 
            // lbDoctorNurse
            // 
            this.lbDoctorNurse.AutoSize = true;
            this.lbDoctorNurse.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoctorNurse.Location = new System.Drawing.Point(3, 39);
            this.lbDoctorNurse.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbDoctorNurse.Name = "lbDoctorNurse";
            this.lbDoctorNurse.Size = new System.Drawing.Size(91, 19);
            this.lbDoctorNurse.TabIndex = 0;
            this.lbDoctorNurse.Text = "Bác sĩ/ Y tá";
            this.lbDoctorNurse.Click += new System.EventHandler(this.lbDoctorNurse_Click);
            this.lbDoctorNurse.MouseEnter += new System.EventHandler(this.Event_MouseEnter);
            this.lbDoctorNurse.MouseLeave += new System.EventHandler(this.Event_MouseLeave);
            // 
            // InfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "InfoList";
            this.Size = new System.Drawing.Size(154, 200);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbDentist;
        private System.Windows.Forms.Label lbDoctorNurse;
    }
}
