namespace MyFirstCSharp
{
    partial class Chap16_Loop_For
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
            this.btnForSum = new System.Windows.Forms.Button();
            this.btnArraySum = new System.Windows.Forms.Button();
            this.txtGUGU = new System.Windows.Forms.TextBox();
            this.btnGUGU = new System.Windows.Forms.Button();
            this.btnIm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForSum
            // 
            this.btnForSum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnForSum.Location = new System.Drawing.Point(0, 0);
            this.btnForSum.Name = "btnForSum";
            this.btnForSum.Size = new System.Drawing.Size(1058, 90);
            this.btnForSum.TabIndex = 0;
            this.btnForSum.Text = "1부터 100까지 더하기";
            this.btnForSum.UseVisualStyleBackColor = true;
            this.btnForSum.Click += new System.EventHandler(this.btnForSum_Click);
            // 
            // btnArraySum
            // 
            this.btnArraySum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArraySum.Location = new System.Drawing.Point(0, 90);
            this.btnArraySum.Name = "btnArraySum";
            this.btnArraySum.Size = new System.Drawing.Size(1058, 90);
            this.btnArraySum.TabIndex = 1;
            this.btnArraySum.Text = "배율 값 더하기";
            this.btnArraySum.UseVisualStyleBackColor = true;
            this.btnArraySum.Click += new System.EventHandler(this.btnArraySum_Click);
            // 
            // txtGUGU
            // 
            this.txtGUGU.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGUGU.Location = new System.Drawing.Point(0, 180);
            this.txtGUGU.Multiline = true;
            this.txtGUGU.Name = "txtGUGU";
            this.txtGUGU.Size = new System.Drawing.Size(1058, 205);
            this.txtGUGU.TabIndex = 2;
            // 
            // btnGUGU
            // 
            this.btnGUGU.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGUGU.Location = new System.Drawing.Point(0, 385);
            this.btnGUGU.Name = "btnGUGU";
            this.btnGUGU.Size = new System.Drawing.Size(1058, 33);
            this.btnGUGU.TabIndex = 3;
            this.btnGUGU.Text = "구구단 표현하기 2~9";
            this.btnGUGU.UseVisualStyleBackColor = true;
            this.btnGUGU.Click += new System.EventHandler(this.btnGUGU_Click);
            // 
            // btnIm
            // 
            this.btnIm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIm.Location = new System.Drawing.Point(0, 418);
            this.btnIm.Name = "btnIm";
            this.btnIm.Size = new System.Drawing.Size(1058, 33);
            this.btnIm.TabIndex = 4;
            this.btnIm.Text = "Immutable\r\n";
            this.btnIm.UseVisualStyleBackColor = true;
            this.btnIm.Click += new System.EventHandler(this.btnIm_Click);
            // 
            // Chap16_Loop_For
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 467);
            this.Controls.Add(this.btnIm);
            this.Controls.Add(this.btnGUGU);
            this.Controls.Add(this.txtGUGU);
            this.Controls.Add(this.btnArraySum);
            this.Controls.Add(this.btnForSum);
            this.Name = "Chap16_Loop_For";
            this.Text = "반복문 for";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForSum;
        private System.Windows.Forms.Button btnArraySum;
        private System.Windows.Forms.TextBox txtGUGU;
        private System.Windows.Forms.Button btnGUGU;
        private System.Windows.Forms.Button btnIm;
    }
}