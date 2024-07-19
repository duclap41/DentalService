namespace DentalService.UserProfile
{
    partial class uctUserProfile
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cBtnInfo = new DentalService.CustomButton();
            this.cBtnHistoryBooking = new DentalService.CustomButton();
            this.PnContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PnContainer, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 640);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.cBtnInfo);
            this.flowLayoutPanel1.Controls.Add(this.cBtnHistoryBooking);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(125, 634);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cBtnInfo
            // 
            this.cBtnInfo.BackColor = System.Drawing.Color.AliceBlue;
            this.cBtnInfo.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.cBtnInfo.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cBtnInfo.BorderRadius = 10;
            this.cBtnInfo.BorderSize = 2;
            this.cBtnInfo.FlatAppearance.BorderSize = 0;
            this.cBtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnInfo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnInfo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cBtnInfo.Location = new System.Drawing.Point(3, 3);
            this.cBtnInfo.Name = "cBtnInfo";
            this.cBtnInfo.Size = new System.Drawing.Size(119, 40);
            this.cBtnInfo.TabIndex = 0;
            this.cBtnInfo.Text = "Thông tin cơ bản";
            this.cBtnInfo.TextColor = System.Drawing.Color.RoyalBlue;
            this.cBtnInfo.UseVisualStyleBackColor = false;
            this.cBtnInfo.Click += new System.EventHandler(this.cbtnInfo_Click);
            // 
            // cBtnHistoryBooking
            // 
            this.cBtnHistoryBooking.BackColor = System.Drawing.Color.AliceBlue;
            this.cBtnHistoryBooking.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.cBtnHistoryBooking.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cBtnHistoryBooking.BorderRadius = 10;
            this.cBtnHistoryBooking.BorderSize = 2;
            this.cBtnHistoryBooking.FlatAppearance.BorderSize = 0;
            this.cBtnHistoryBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnHistoryBooking.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnHistoryBooking.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cBtnHistoryBooking.Location = new System.Drawing.Point(3, 49);
            this.cBtnHistoryBooking.Name = "cBtnHistoryBooking";
            this.cBtnHistoryBooking.Size = new System.Drawing.Size(119, 40);
            this.cBtnHistoryBooking.TabIndex = 0;
            this.cBtnHistoryBooking.Text = "Lịch sử đặt lịch";
            this.cBtnHistoryBooking.TextColor = System.Drawing.Color.RoyalBlue;
            this.cBtnHistoryBooking.UseVisualStyleBackColor = false;
            this.cBtnHistoryBooking.Click += new System.EventHandler(this.cbtnHistoryBooking_Click);
            // 
            // PnContainer
            // 
            this.PnContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnContainer.Location = new System.Drawing.Point(131, 3);
            this.PnContainer.Name = "PnContainer";
            this.PnContainer.Size = new System.Drawing.Size(1146, 634);
            this.PnContainer.TabIndex = 1;
            // 
            // uctUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uctUserProfile";
            this.Size = new System.Drawing.Size(1280, 640);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomButton cBtnInfo;
        private CustomButton cBtnHistoryBooking;
        private System.Windows.Forms.Panel PnContainer;
    }
}
