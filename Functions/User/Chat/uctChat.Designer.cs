namespace DentalService.Chat
{
    partial class uctChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctChat));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtChatBox = new DentalService.RJTextBox();
            this.picSend = new System.Windows.Forms.PictureBox();
            this.fLPContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.customPanel1 = new DentalService.CustomPanel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).BeginInit();
            this.fLPContainer.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fLPContainer, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 280);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liên hệ tư vấn qua Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.Controls.Add(this.txtChatBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.picSend, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 230);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(300, 50);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtChatBox
            // 
            this.txtChatBox.BackColor = System.Drawing.SystemColors.Window;
            this.txtChatBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtChatBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtChatBox.BorderRadius = 15;
            this.txtChatBox.BorderSize = 2;
            this.txtChatBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChatBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtChatBox.Location = new System.Drawing.Point(2, 2);
            this.txtChatBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtChatBox.Multiline = true;
            this.txtChatBox.Name = "txtChatBox";
            this.txtChatBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtChatBox.PasswordChar = false;
            this.txtChatBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtChatBox.PlaceholderText = "";
            this.txtChatBox.Size = new System.Drawing.Size(245, 46);
            this.txtChatBox.TabIndex = 0;
            this.txtChatBox.Texts = "";
            this.txtChatBox.UnderlinedStyle = true;
            // 
            // picSend
            // 
            this.picSend.Image = ((System.Drawing.Image)(resources.GetObject("picSend.Image")));
            this.picSend.Location = new System.Drawing.Point(252, 3);
            this.picSend.Name = "picSend";
            this.picSend.Size = new System.Drawing.Size(45, 44);
            this.picSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSend.TabIndex = 3;
            this.picSend.TabStop = false;
            this.picSend.Click += new System.EventHandler(this.picSend_Click);
            // 
            // fLPContainer
            // 
            this.fLPContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fLPContainer.AutoScroll = true;
            this.tableLayoutPanel1.SetColumnSpan(this.fLPContainer, 3);
            this.fLPContainer.Controls.Add(this.customPanel1);
            this.fLPContainer.Location = new System.Drawing.Point(0, 30);
            this.fLPContainer.Margin = new System.Windows.Forms.Padding(0);
            this.fLPContainer.Name = "fLPContainer";
            this.fLPContainer.Size = new System.Drawing.Size(350, 200);
            this.fLPContainer.TabIndex = 2;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customPanel1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.customPanel1.BorderRadius = 20;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.lbMessage);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.customPanel1.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.customPanel1.Location = new System.Drawing.Point(3, 3);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 3);
            this.customPanel1.Size = new System.Drawing.Size(310, 38);
            this.customPanel1.TabIndex = 1;
            this.customPanel1.UseGradient = false;
            // 
            // lbMessage
            // 
            this.lbMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMessage.Location = new System.Drawing.Point(10, 5);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(2);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(290, 30);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "Vui lòng để lại SĐT hoặc Email để chúng tôi có thể dễ dàng trả lời cho bạn!";
            // 
            // uctChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uctChat";
            this.Size = new System.Drawing.Size(350, 280);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).EndInit();
            this.fLPContainer.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private RJTextBox txtChatBox;
        private System.Windows.Forms.FlowLayoutPanel fLPContainer;
        private System.Windows.Forms.PictureBox picSend;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Label lbMessage;
    }
}
