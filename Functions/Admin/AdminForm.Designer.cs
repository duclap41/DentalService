namespace DentalService
{
    partial class AdminForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnWindowControl = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picZoom = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.customTableLayoutPanel1 = new DentalService.CustomTableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnWindowControl.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            this.customTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnWindowControl
            // 
            this.pnWindowControl.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnWindowControl.Controls.Add(this.flowLayoutPanel2);
            this.pnWindowControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnWindowControl.Location = new System.Drawing.Point(0, 0);
            this.pnWindowControl.Name = "pnWindowControl";
            this.pnWindowControl.Size = new System.Drawing.Size(1280, 30);
            this.pnWindowControl.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.picClose);
            this.flowLayoutPanel2.Controls.Add(this.picZoom);
            this.flowLayoutPanel2.Controls.Add(this.picMinimize);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1185, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(95, 30);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // picClose
            // 
            this.picClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picClose.Image = global::DentalService.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(67, 3);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(25, 25);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picZoom
            // 
            this.picZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picZoom.Image = global::DentalService.Properties.Resources.zoom_out;
            this.picZoom.Location = new System.Drawing.Point(36, 3);
            this.picZoom.Name = "picZoom";
            this.picZoom.Size = new System.Drawing.Size(25, 25);
            this.picZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picZoom.TabIndex = 2;
            this.picZoom.TabStop = false;
            this.picZoom.Click += new System.EventHandler(this.picZoom_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMinimize.Image = global::DentalService.Properties.Resources.minimize;
            this.picMinimize.Location = new System.Drawing.Point(5, 3);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(25, 25);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimize.TabIndex = 2;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // customTableLayoutPanel1
            // 
            this.customTableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customTableLayoutPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customTableLayoutPanel1.BorderColor = System.Drawing.Color.Black;
            this.customTableLayoutPanel1.BorderRadius = 5;
            this.customTableLayoutPanel1.BorderSize = 1;
            this.customTableLayoutPanel1.ColumnCount = 2;
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customTableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.customTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customTableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.customTableLayoutPanel1.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.customTableLayoutPanel1.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.customTableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.customTableLayoutPanel1.Name = "customTableLayoutPanel1";
            this.customTableLayoutPanel1.RowCount = 1;
            this.customTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customTableLayoutPanel1.Size = new System.Drawing.Size(1280, 50);
            this.customTableLayoutPanel1.TabIndex = 2;
            this.customTableLayoutPanel1.UseGradient = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Big Shoulders Stencil Text Blac", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.customTableLayoutPanel1);
            this.Controls.Add(this.pnWindowControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.pnWindowControl.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            this.customTableLayoutPanel1.ResumeLayout(false);
            this.customTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnWindowControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picZoom;
        private System.Windows.Forms.PictureBox picMinimize;
        private CustomTableLayoutPanel customTableLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}