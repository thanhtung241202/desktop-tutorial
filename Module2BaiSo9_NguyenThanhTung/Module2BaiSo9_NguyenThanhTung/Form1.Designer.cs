namespace Module2BaiSo9_NguyenThanhTung
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
            this.lnkWinForms = new System.Windows.Forms.LinkLabel();
            this.lnkPrograms = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lnkWinForms
            // 
            this.lnkWinForms.AutoSize = true;
            this.lnkWinForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkWinForms.Location = new System.Drawing.Point(125, 59);
            this.lnkWinForms.Name = "lnkWinForms";
            this.lnkWinForms.Size = new System.Drawing.Size(267, 20);
            this.lnkWinForms.TabIndex = 0;
            this.lnkWinForms.TabStop = true;
            this.lnkWinForms.Text = "Windows Forms Community Website";
            // 
            // lnkPrograms
            // 
            this.lnkPrograms.AutoSize = true;
            this.lnkPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkPrograms.Location = new System.Drawing.Point(125, 131);
            this.lnkPrograms.Name = "lnkPrograms";
            this.lnkPrograms.Size = new System.Drawing.Size(253, 20);
            this.lnkPrograms.TabIndex = 1;
            this.lnkPrograms.TabStop = true;
            this.lnkPrograms.Text = "Launch Calculator | Open C: Driver";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 306);
            this.Controls.Add(this.lnkPrograms);
            this.Controls.Add(this.lnkWinForms);
            this.Name = "Form1";
            this.Text = "StepbyStep2_7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkWinForms;
        private System.Windows.Forms.LinkLabel lnkPrograms;
    }
}

