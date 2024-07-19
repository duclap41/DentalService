namespace DentalService
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnWindowControl = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picZoom = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.pnContainChat = new DentalService.CustomPanel();
            this.picCloseChat = new System.Windows.Forms.PictureBox();
            this.picQrScan = new DentalService.CustomPictureBox();
            this.tLPnDropBox = new DentalService.CustomTableLayoutPanel();
            this.cTLPn = new DentalService.CustomTableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cBtnSignIn = new DentalService.CustomButton();
            this.cBtnBooking = new DentalService.CustomButton();
            this.lbButtonUserProfile = new System.Windows.Forms.Label();
            this.lbButtonService = new System.Windows.Forms.Label();
            this.lbButtonInfo = new System.Windows.Forms.Label();
            this.lbButtonHomepage = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picOpenChat = new DentalService.CustomPictureBox();
            this.pnWindowControl.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            this.pnContainer.SuspendLayout();
            this.pnContainChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQrScan)).BeginInit();
            this.cTLPn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenChat)).BeginInit();
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
            this.pnWindowControl.TabIndex = 0;
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
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.AliceBlue;
            this.pnContainer.Controls.Add(this.pnContainChat);
            this.pnContainer.Controls.Add(this.picOpenChat);
            this.pnContainer.Controls.Add(this.picQrScan);
            this.pnContainer.Controls.Add(this.tLPnDropBox);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 80);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1280, 640);
            this.pnContainer.TabIndex = 9;
            // 
            // pnContainChat
            // 
            this.pnContainChat.BackColor = System.Drawing.Color.White;
            this.pnContainChat.BackgroundColor = System.Drawing.Color.White;
            this.pnContainChat.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pnContainChat.BorderRadius = 10;
            this.pnContainChat.BorderSize = 3;
            this.pnContainChat.Controls.Add(this.picCloseChat);
            this.pnContainChat.ForeColor = System.Drawing.Color.Black;
            this.pnContainChat.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.pnContainChat.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.pnContainChat.Location = new System.Drawing.Point(927, 360);
            this.pnContainChat.Name = "pnContainChat";
            this.pnContainChat.Padding = new System.Windows.Forms.Padding(4);
            this.pnContainChat.Size = new System.Drawing.Size(350, 280);
            this.pnContainChat.TabIndex = 2;
            this.pnContainChat.UseGradient = false;
            this.pnContainChat.Visible = false;
            // 
            // picCloseChat
            // 
            this.picCloseChat.BackColor = System.Drawing.Color.RoyalBlue;
            this.picCloseChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCloseChat.Image = global::DentalService.Properties.Resources.close;
            this.picCloseChat.Location = new System.Drawing.Point(318, 7);
            this.picCloseChat.Name = "picCloseChat";
            this.picCloseChat.Size = new System.Drawing.Size(25, 25);
            this.picCloseChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCloseChat.TabIndex = 3;
            this.picCloseChat.TabStop = false;
            this.picCloseChat.Click += new System.EventHandler(this.picCloseChat_Click);
            // 
            // picQrScan
            // 
            this.picQrScan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picQrScan.BackColor = System.Drawing.Color.Transparent;
            this.picQrScan.BackgroundColor = System.Drawing.Color.Transparent;
            this.picQrScan.BorderColor = System.Drawing.Color.DarkBlue;
            this.picQrScan.BorderRadius = 10;
            this.picQrScan.BorderSize = 2;
            this.picQrScan.ForeColor = System.Drawing.Color.Black;
            this.picQrScan.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.picQrScan.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.picQrScan.Image = ((System.Drawing.Image)(resources.GetObject("picQrScan.Image")));
            this.picQrScan.Location = new System.Drawing.Point(1217, 296);
            this.picQrScan.Name = "picQrScan";
            this.picQrScan.Size = new System.Drawing.Size(60, 60);
            this.picQrScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQrScan.TabIndex = 1;
            this.picQrScan.TabStop = false;
            this.picQrScan.UseGradient = false;
            this.picQrScan.Click += new System.EventHandler(this.picQrScan_Click);
            // 
            // tLPnDropBox
            // 
            this.tLPnDropBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLPnDropBox.BackColor = System.Drawing.Color.MintCream;
            this.tLPnDropBox.BackgroundColor = System.Drawing.Color.MintCream;
            this.tLPnDropBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.tLPnDropBox.BorderRadius = 20;
            this.tLPnDropBox.BorderSize = 1;
            this.tLPnDropBox.ColumnCount = 4;
            this.tLPnDropBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.34375F));
            this.tLPnDropBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.42188F));
            this.tLPnDropBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.29688F));
            this.tLPnDropBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.85938F));
            this.tLPnDropBox.ForeColor = System.Drawing.Color.Black;
            this.tLPnDropBox.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.tLPnDropBox.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.tLPnDropBox.Location = new System.Drawing.Point(0, 0);
            this.tLPnDropBox.Margin = new System.Windows.Forms.Padding(0);
            this.tLPnDropBox.Name = "tLPnDropBox";
            this.tLPnDropBox.RowCount = 1;
            this.tLPnDropBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPnDropBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tLPnDropBox.Size = new System.Drawing.Size(1280, 200);
            this.tLPnDropBox.TabIndex = 0;
            this.tLPnDropBox.UseGradient = false;
            this.tLPnDropBox.Visible = false;
            // 
            // cTLPn
            // 
            this.cTLPn.BackColor = System.Drawing.Color.AliceBlue;
            this.cTLPn.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.cTLPn.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cTLPn.BorderRadius = 7;
            this.cTLPn.BorderSize = 1;
            this.cTLPn.ColumnCount = 8;
            this.cTLPn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.04688F));
            this.cTLPn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.953125F));
            this.cTLPn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.cTLPn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.cTLPn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.cTLPn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.cTLPn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.cTLPn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.cTLPn.Controls.Add(this.label2, 0, 0);
            this.cTLPn.Controls.Add(this.cBtnSignIn, 6, 0);
            this.cTLPn.Controls.Add(this.cBtnBooking, 7, 0);
            this.cTLPn.Controls.Add(this.lbButtonUserProfile, 5, 0);
            this.cTLPn.Controls.Add(this.lbButtonService, 4, 0);
            this.cTLPn.Controls.Add(this.lbButtonInfo, 3, 0);
            this.cTLPn.Controls.Add(this.lbButtonHomepage, 2, 0);
            this.cTLPn.Controls.Add(this.pictureBox2, 1, 0);
            this.cTLPn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cTLPn.ForeColor = System.Drawing.Color.Black;
            this.cTLPn.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.cTLPn.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.cTLPn.Location = new System.Drawing.Point(0, 30);
            this.cTLPn.Name = "cTLPn";
            this.cTLPn.RowCount = 1;
            this.cTLPn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cTLPn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.cTLPn.Size = new System.Drawing.Size(1280, 50);
            this.cTLPn.TabIndex = 8;
            this.cTLPn.UseGradient = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Big Shoulders Stencil Text Blac", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nha khoa Lập Đức";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBtnSignIn
            // 
            this.cBtnSignIn.BackColor = System.Drawing.Color.Azure;
            this.cBtnSignIn.BackgroundColor = System.Drawing.Color.Azure;
            this.cBtnSignIn.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cBtnSignIn.BorderRadius = 20;
            this.cBtnSignIn.BorderSize = 2;
            this.cBtnSignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBtnSignIn.FlatAppearance.BorderSize = 0;
            this.cBtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnSignIn.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnSignIn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cBtnSignIn.Location = new System.Drawing.Point(958, 3);
            this.cBtnSignIn.Name = "cBtnSignIn";
            this.cBtnSignIn.Size = new System.Drawing.Size(153, 44);
            this.cBtnSignIn.TabIndex = 2;
            this.cBtnSignIn.Text = "Đăng nhập";
            this.cBtnSignIn.TextColor = System.Drawing.Color.DodgerBlue;
            this.cBtnSignIn.UseVisualStyleBackColor = false;
            this.cBtnSignIn.Click += new System.EventHandler(this.cBtnSignIn_Click);
            // 
            // cBtnBooking
            // 
            this.cBtnBooking.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBtnBooking.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.cBtnBooking.BorderColor = System.Drawing.Color.OrangeRed;
            this.cBtnBooking.BorderRadius = 20;
            this.cBtnBooking.BorderSize = 2;
            this.cBtnBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBtnBooking.FlatAppearance.BorderSize = 0;
            this.cBtnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnBooking.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnBooking.ForeColor = System.Drawing.Color.OrangeRed;
            this.cBtnBooking.Location = new System.Drawing.Point(1117, 3);
            this.cBtnBooking.Name = "cBtnBooking";
            this.cBtnBooking.Size = new System.Drawing.Size(160, 44);
            this.cBtnBooking.TabIndex = 1;
            this.cBtnBooking.Text = "Đặt lịch ngay";
            this.cBtnBooking.TextColor = System.Drawing.Color.OrangeRed;
            this.cBtnBooking.UseVisualStyleBackColor = false;
            this.cBtnBooking.Click += new System.EventHandler(this.cBtnBooking_Click);
            // 
            // lbButtonUserProfile
            // 
            this.lbButtonUserProfile.BackColor = System.Drawing.Color.AliceBlue;
            this.lbButtonUserProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbButtonUserProfile.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbButtonUserProfile.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbButtonUserProfile.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbButtonUserProfile.Location = new System.Drawing.Point(801, 5);
            this.lbButtonUserProfile.Margin = new System.Windows.Forms.Padding(5, 5, 5, 1);
            this.lbButtonUserProfile.Name = "lbButtonUserProfile";
            this.lbButtonUserProfile.Size = new System.Drawing.Size(149, 44);
            this.lbButtonUserProfile.TabIndex = 0;
            this.lbButtonUserProfile.Text = "Hồ sơ";
            this.lbButtonUserProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbButtonUserProfile.Visible = false;
            this.lbButtonUserProfile.Click += new System.EventHandler(this.lbButtonUserProfile_Click);
            this.lbButtonUserProfile.MouseEnter += new System.EventHandler(this.lbButtonUserProfile_MouseEnter);
            this.lbButtonUserProfile.MouseLeave += new System.EventHandler(this.lbButtonUserProfile_MouseLeave);
            // 
            // lbButtonService
            // 
            this.lbButtonService.BackColor = System.Drawing.Color.Transparent;
            this.lbButtonService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbButtonService.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbButtonService.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbButtonService.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbButtonService.Location = new System.Drawing.Point(642, 5);
            this.lbButtonService.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lbButtonService.Name = "lbButtonService";
            this.lbButtonService.Size = new System.Drawing.Size(149, 45);
            this.lbButtonService.TabIndex = 1;
            this.lbButtonService.Text = "Dịch vụ";
            this.lbButtonService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbButtonService.MouseEnter += new System.EventHandler(this.lbButtonService_MouseEnter);
            this.lbButtonService.MouseLeave += new System.EventHandler(this.lbButtonService_MouseLeave);
            // 
            // lbButtonInfo
            // 
            this.lbButtonInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbButtonInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbButtonInfo.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbButtonInfo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbButtonInfo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbButtonInfo.Location = new System.Drawing.Point(483, 5);
            this.lbButtonInfo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lbButtonInfo.Name = "lbButtonInfo";
            this.lbButtonInfo.Size = new System.Drawing.Size(149, 45);
            this.lbButtonInfo.TabIndex = 1;
            this.lbButtonInfo.Text = "Thông tin";
            this.lbButtonInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbButtonInfo.MouseEnter += new System.EventHandler(this.lbButtonInfo_MouseEnter);
            this.lbButtonInfo.MouseLeave += new System.EventHandler(this.lbButtonInfo_MouseLeave);
            // 
            // lbButtonHomepage
            // 
            this.lbButtonHomepage.BackColor = System.Drawing.Color.AliceBlue;
            this.lbButtonHomepage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbButtonHomepage.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbButtonHomepage.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbButtonHomepage.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbButtonHomepage.Location = new System.Drawing.Point(324, 5);
            this.lbButtonHomepage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 1);
            this.lbButtonHomepage.Name = "lbButtonHomepage";
            this.lbButtonHomepage.Size = new System.Drawing.Size(149, 44);
            this.lbButtonHomepage.TabIndex = 0;
            this.lbButtonHomepage.Text = "Trang chủ";
            this.lbButtonHomepage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbButtonHomepage.Click += new System.EventHandler(this.lbButtonHomepage_Click);
            this.lbButtonHomepage.MouseEnter += new System.EventHandler(this.lbButtonHomepage_MouseEnter);
            this.lbButtonHomepage.MouseLeave += new System.EventHandler(this.lbButtonHomepage_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(231, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // picOpenChat
            // 
            this.picOpenChat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picOpenChat.BackColor = System.Drawing.Color.Transparent;
            this.picOpenChat.BackgroundColor = System.Drawing.Color.Transparent;
            this.picOpenChat.BorderColor = System.Drawing.Color.DarkBlue;
            this.picOpenChat.BorderRadius = 10;
            this.picOpenChat.BorderSize = 2;
            this.picOpenChat.ForeColor = System.Drawing.Color.Black;
            this.picOpenChat.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.picOpenChat.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.picOpenChat.Image = ((System.Drawing.Image)(resources.GetObject("picOpenChat.Image")));
            this.picOpenChat.Location = new System.Drawing.Point(1217, 361);
            this.picOpenChat.Name = "picOpenChat";
            this.picOpenChat.Size = new System.Drawing.Size(60, 60);
            this.picOpenChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOpenChat.TabIndex = 1;
            this.picOpenChat.TabStop = false;
            this.picOpenChat.UseGradient = false;
            this.picOpenChat.Click += new System.EventHandler(this.picOpenChat_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.cTLPn);
            this.Controls.Add(this.pnWindowControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dental Service";
            this.pnWindowControl.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            this.pnContainer.ResumeLayout(false);
            this.pnContainChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCloseChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQrScan)).EndInit();
            this.cTLPn.ResumeLayout(false);
            this.cTLPn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenChat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnWindowControl;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picZoom;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lbButtonHomepage;
        private System.Windows.Forms.Label lbButtonInfo;
        private System.Windows.Forms.Label lbButtonService;
        private System.Windows.Forms.Label lbButtonUserProfile;
        private CustomButton cBtnBooking;
        private CustomButton cBtnSignIn;
        private CustomTableLayoutPanel cTLPn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnContainer;
        private CustomTableLayoutPanel tLPnDropBox;
        private CustomPictureBox picQrScan;
        private CustomPanel pnContainChat;
        private System.Windows.Forms.PictureBox picCloseChat;
        private CustomPictureBox picOpenChat;
    }
}

