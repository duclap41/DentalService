namespace DentalService.Info.DoctorNurse
{
    partial class DoctorNurseBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorNurseBar));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picAvatar = new DentalService.CustomPictureBox();
            this.customTableLayoutPanel1 = new DentalService.CustomTableLayoutPanel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lBoxEducation = new System.Windows.Forms.ListBox();
            this.lBoxHobby = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.customTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.picAvatar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.customTableLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1250, 250);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.BackgroundColor = System.Drawing.Color.Transparent;
            this.picAvatar.BorderColor = System.Drawing.Color.Chocolate;
            this.picAvatar.BorderRadius = 30;
            this.picAvatar.BorderSize = 3;
            this.picAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAvatar.ForeColor = System.Drawing.Color.Black;
            this.picAvatar.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.picAvatar.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.picAvatar.Location = new System.Drawing.Point(20, 5);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(300, 240);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 4;
            this.picAvatar.TabStop = false;
            this.picAvatar.UseGradient = false;
            // 
            // customTableLayoutPanel1
            // 
            this.customTableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customTableLayoutPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customTableLayoutPanel1.BorderColor = System.Drawing.Color.Chocolate;
            this.customTableLayoutPanel1.BorderRadius = 5;
            this.customTableLayoutPanel1.BorderSize = 3;
            this.customTableLayoutPanel1.ColumnCount = 2;
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.customTableLayoutPanel1.Controls.Add(this.lbName, 0, 0);
            this.customTableLayoutPanel1.Controls.Add(this.lbDescription, 0, 1);
            this.customTableLayoutPanel1.Controls.Add(this.lBoxEducation, 1, 0);
            this.customTableLayoutPanel1.Controls.Add(this.lBoxHobby, 1, 1);
            this.customTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.customTableLayoutPanel1.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.customTableLayoutPanel1.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.customTableLayoutPanel1.Location = new System.Drawing.Point(335, 5);
            this.customTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.customTableLayoutPanel1.Name = "customTableLayoutPanel1";
            this.customTableLayoutPanel1.RowCount = 2;
            this.customTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.customTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.customTableLayoutPanel1.Size = new System.Drawing.Size(910, 240);
            this.customTableLayoutPanel1.TabIndex = 5;
            this.customTableLayoutPanel1.UseGradient = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("PT Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(3, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(403, 120);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Bác sĩ: Graham Shadwick";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDescription.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(3, 123);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(3);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(403, 114);
            this.lbDescription.TabIndex = 1;
            this.lbDescription.Text = resources.GetString("lbDescription.Text");
            // 
            // lBoxEducation
            // 
            this.lBoxEducation.BackColor = System.Drawing.Color.AliceBlue;
            this.lBoxEducation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxEducation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBoxEducation.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxEducation.FormattingEnabled = true;
            this.lBoxEducation.ItemHeight = 21;
            this.lBoxEducation.Items.AddRange(new object[] {
            "Học vấn:"});
            this.lBoxEducation.Location = new System.Drawing.Point(424, 5);
            this.lBoxEducation.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.lBoxEducation.Name = "lBoxEducation";
            this.lBoxEducation.Size = new System.Drawing.Size(481, 110);
            this.lBoxEducation.TabIndex = 2;
            // 
            // lBoxHobby
            // 
            this.lBoxHobby.BackColor = System.Drawing.Color.AliceBlue;
            this.lBoxHobby.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxHobby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBoxHobby.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxHobby.FormattingEnabled = true;
            this.lBoxHobby.ItemHeight = 19;
            this.lBoxHobby.Items.AddRange(new object[] {
            "Sở thích:"});
            this.lBoxHobby.Location = new System.Drawing.Point(424, 125);
            this.lBoxHobby.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.lBoxHobby.Name = "lBoxHobby";
            this.lBoxHobby.Size = new System.Drawing.Size(481, 110);
            this.lBoxHobby.TabIndex = 2;
            // 
            // DoctorNurseBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DoctorNurseBar";
            this.Size = new System.Drawing.Size(1250, 250);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.customTableLayoutPanel1.ResumeLayout(false);
            this.customTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomPictureBox picAvatar;
        private CustomTableLayoutPanel customTableLayoutPanel1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.ListBox lBoxEducation;
        private System.Windows.Forms.ListBox lBoxHobby;
    }
}
