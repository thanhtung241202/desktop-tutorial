namespace Modulo2BaiSo8_NguyenThanhTung
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.EnterALable = new System.Windows.Forms.Label();
            this.EnterAtxbx = new System.Windows.Forms.TextBox();
            this.EnterBtxbx = new System.Windows.Forms.TextBox();
            this.EnterBLabel = new System.Windows.Forms.Label();
            this.NghiemLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(95, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHƯƠNG TRÌNH: AX + B";
            // 
            // EnterALable
            // 
            this.EnterALable.AutoSize = true;
            this.EnterALable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterALable.Location = new System.Drawing.Point(68, 79);
            this.EnterALable.Name = "EnterALable";
            this.EnterALable.Size = new System.Drawing.Size(60, 18);
            this.EnterALable.TabIndex = 1;
            this.EnterALable.Text = "Nhập A:";
            // 
            // EnterAtxbx
            // 
            this.EnterAtxbx.Location = new System.Drawing.Point(130, 80);
            this.EnterAtxbx.Name = "EnterAtxbx";
            this.EnterAtxbx.Size = new System.Drawing.Size(274, 20);
            this.EnterAtxbx.TabIndex = 2;
            // 
            // EnterBtxbx
            // 
            this.EnterBtxbx.Location = new System.Drawing.Point(130, 130);
            this.EnterBtxbx.Name = "EnterBtxbx";
            this.EnterBtxbx.Size = new System.Drawing.Size(274, 20);
            this.EnterBtxbx.TabIndex = 4;
            // 
            // EnterBLabel
            // 
            this.EnterBLabel.AutoSize = true;
            this.EnterBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterBLabel.Location = new System.Drawing.Point(67, 129);
            this.EnterBLabel.Name = "EnterBLabel";
            this.EnterBLabel.Size = new System.Drawing.Size(61, 18);
            this.EnterBLabel.TabIndex = 3;
            this.EnterBLabel.Text = "Nhập B:";
            // 
            // NghiemLable
            // 
            this.NghiemLable.AutoSize = true;
            this.NghiemLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NghiemLable.Location = new System.Drawing.Point(31, 173);
            this.NghiemLable.Name = "NghiemLable";
            this.NghiemLable.Size = new System.Drawing.Size(86, 18);
            this.NghiemLable.TabIndex = 5;
            this.NghiemLable.Text = "Nghiệm PT:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 332);
            this.Controls.Add(this.NghiemLable);
            this.Controls.Add(this.EnterBtxbx);
            this.Controls.Add(this.EnterBLabel);
            this.Controls.Add(this.EnterAtxbx);
            this.Controls.Add(this.EnterALable);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Giải phương trình bậc 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EnterALable;
        private System.Windows.Forms.TextBox EnterAtxbx;
        private System.Windows.Forms.TextBox EnterBtxbx;
        private System.Windows.Forms.Label EnterBLabel;
        private System.Windows.Forms.Label NghiemLable;
    }
}

