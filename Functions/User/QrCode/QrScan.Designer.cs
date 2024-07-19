namespace DentalService.QrCode
{
    partial class QrScan
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
            this.components = new System.ComponentModel.Container();
            this.customTableLayoutPanel1 = new DentalService.CustomTableLayoutPanel();
            this.pnWindowControl = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picZoom = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picCamera = new DentalService.CustomPictureBox();
            this.btnScan = new DentalService.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.customTableLayoutPanel1.SuspendLayout();
            this.pnWindowControl.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // customTableLayoutPanel1
            // 
            this.customTableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customTableLayoutPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customTableLayoutPanel1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customTableLayoutPanel1.BorderRadius = 0;
            this.customTableLayoutPanel1.BorderSize = 2;
            this.customTableLayoutPanel1.ColumnCount = 3;
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.customTableLayoutPanel1.Controls.Add(this.pnWindowControl, 0, 0);
            this.customTableLayoutPanel1.Controls.Add(this.picCamera, 1, 2);
            this.customTableLayoutPanel1.Controls.Add(this.btnScan, 1, 3);
            this.customTableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.customTableLayoutPanel1.Controls.Add(this.textBox1, 1, 4);
            this.customTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.customTableLayoutPanel1.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.customTableLayoutPanel1.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.customTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.customTableLayoutPanel1.Name = "customTableLayoutPanel1";
            this.customTableLayoutPanel1.RowCount = 5;
            this.customTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.customTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.customTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.customTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.customTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customTableLayoutPanel1.Size = new System.Drawing.Size(500, 640);
            this.customTableLayoutPanel1.TabIndex = 0;
            this.customTableLayoutPanel1.UseGradient = false;
            // 
            // pnWindowControl
            // 
            this.pnWindowControl.BackColor = System.Drawing.Color.DodgerBlue;
            this.customTableLayoutPanel1.SetColumnSpan(this.pnWindowControl, 3);
            this.pnWindowControl.Controls.Add(this.flowLayoutPanel2);
            this.pnWindowControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnWindowControl.Location = new System.Drawing.Point(2, 2);
            this.pnWindowControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.pnWindowControl.Name = "pnWindowControl";
            this.pnWindowControl.Size = new System.Drawing.Size(496, 28);
            this.pnWindowControl.TabIndex = 1;
            this.pnWindowControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnWindowControl_MouseDown);
            this.pnWindowControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnWindowControl_MouseMove);
            this.pnWindowControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnWindowControl_MouseUp);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.picClose);
            this.flowLayoutPanel2.Controls.Add(this.picZoom);
            this.flowLayoutPanel2.Controls.Add(this.picMinimize);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(401, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(95, 28);
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
            // picCamera
            // 
            this.picCamera.BackColor = System.Drawing.Color.Transparent;
            this.picCamera.BackgroundColor = System.Drawing.Color.Transparent;
            this.picCamera.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picCamera.BorderRadius = 20;
            this.picCamera.BorderSize = 3;
            this.picCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCamera.ForeColor = System.Drawing.Color.Black;
            this.picCamera.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.picCamera.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.picCamera.Location = new System.Drawing.Point(53, 83);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(394, 394);
            this.picCamera.TabIndex = 2;
            this.picCamera.TabStop = false;
            this.picCamera.UseGradient = false;
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.LightCyan;
            this.btnScan.BackgroundColor = System.Drawing.Color.LightCyan;
            this.btnScan.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnScan.BorderRadius = 10;
            this.btnScan.BorderSize = 3;
            this.btnScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnScan.FlatAppearance.BorderSize = 0;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnScan.Location = new System.Drawing.Point(53, 483);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(394, 44);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "Nhấn để Quét!";
            this.btnScan.TextColor = System.Drawing.Color.RoyalBlue;
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quét QR lịch đã đặt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 533);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 20);
            this.textBox1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QrScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(500, 640);
            this.Controls.Add(this.customTableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QrScan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QrScan";
            this.customTableLayoutPanel1.ResumeLayout(false);
            this.customTableLayoutPanel1.PerformLayout();
            this.pnWindowControl.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomTableLayoutPanel customTableLayoutPanel1;
        private System.Windows.Forms.Panel pnWindowControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picZoom;
        private System.Windows.Forms.PictureBox picMinimize;
        private CustomPictureBox picCamera;
        private CustomButton btnScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}