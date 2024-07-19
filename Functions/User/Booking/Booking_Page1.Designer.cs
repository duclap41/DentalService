namespace DentalService.Booking
{
    partial class Booking_Page1
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cBtnNext = new DentalService.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cTxtLastName = new DentalService.CustomTextBox();
            this.cTxtFirstName = new DentalService.CustomTextBox();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.cBtnNext, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(448, 464);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(439, 39);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // cBtnNext
            // 
            this.cBtnNext.BackColor = System.Drawing.Color.AliceBlue;
            this.cBtnNext.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.cBtnNext.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cBtnNext.BorderRadius = 17;
            this.cBtnNext.BorderSize = 2;
            this.cBtnNext.FlatAppearance.BorderSize = 0;
            this.cBtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnNext.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtnNext.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cBtnNext.Location = new System.Drawing.Point(350, 3);
            this.cBtnNext.Name = "cBtnNext";
            this.cBtnNext.Size = new System.Drawing.Size(86, 33);
            this.cBtnNext.TabIndex = 0;
            this.cBtnNext.Text = "Sau";
            this.cBtnNext.TextColor = System.Drawing.Color.DodgerBlue;
            this.cBtnNext.UseVisualStyleBackColor = false;
            this.cBtnNext.Click += new System.EventHandler(this.cBtnNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên của bạn là gì?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chào mừng đến với nha khoa Lập Đức";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cTxtLastName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cTxtFirstName, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 506);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cTxtLastName
            // 
            this.cTxtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cTxtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTxtLastName.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.cTxtLastName.ForeColor = System.Drawing.Color.Gray;
            this.cTxtLastName.Location = new System.Drawing.Point(3, 132);
            this.cTxtLastName.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.cTxtLastName.Name = "cTxtLastName";
            this.cTxtLastName.PlaceholderColor = System.Drawing.Color.Gray;
            this.cTxtLastName.PlaceholderText = "Họ";
            this.cTxtLastName.Size = new System.Drawing.Size(342, 40);
            this.cTxtLastName.TabIndex = 9;
            this.cTxtLastName.Text = "Họ";
            this.cTxtLastName.TextColor = System.Drawing.Color.Black;
            // 
            // cTxtFirstName
            // 
            this.cTxtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cTxtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTxtFirstName.Font = new System.Drawing.Font("Roboto", 20.25F);
            this.cTxtFirstName.ForeColor = System.Drawing.Color.Gray;
            this.cTxtFirstName.Location = new System.Drawing.Point(448, 132);
            this.cTxtFirstName.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.cTxtFirstName.Name = "cTxtFirstName";
            this.cTxtFirstName.PlaceholderColor = System.Drawing.Color.Gray;
            this.cTxtFirstName.PlaceholderText = "Tên";
            this.cTxtFirstName.Size = new System.Drawing.Size(342, 40);
            this.cTxtFirstName.TabIndex = 9;
            this.cTxtFirstName.Text = "Tên";
            this.cTxtFirstName.TextColor = System.Drawing.Color.Black;
            // 
            // Booking_Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Booking_Page1";
            this.Size = new System.Drawing.Size(890, 506);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private CustomButton cBtnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomTextBox cTxtLastName;
        private CustomTextBox cTxtFirstName;
    }
}
