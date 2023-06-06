namespace MyFirstCSharp
{
    partial class Chap11_BranchingStatement
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
            this.btnIf = new System.Windows.Forms.Button();
            this.txtBS = new System.Windows.Forms.TextBox();
            this.btnInIf = new System.Windows.Forms.Button();
            this.btnElseIf = new System.Windows.Forms.Button();
            this.btnAndIf = new System.Windows.Forms.Button();
            this.btnOrIf = new System.Windows.Forms.Button();
            this.btnBoolIf = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIf
            // 
            this.btnIf.Location = new System.Drawing.Point(12, 39);
            this.btnIf.Name = "btnIf";
            this.btnIf.Size = new System.Drawing.Size(167, 123);
            this.btnIf.TabIndex = 0;
            this.btnIf.Text = "IF";
            this.btnIf.UseVisualStyleBackColor = true;
            this.btnIf.Click += new System.EventHandler(this.btnIf_Click);
            // 
            // txtBS
            // 
            this.txtBS.Location = new System.Drawing.Point(12, 12);
            this.txtBS.Name = "txtBS";
            this.txtBS.Size = new System.Drawing.Size(167, 21);
            this.txtBS.TabIndex = 1;
            // 
            // btnInIf
            // 
            this.btnInIf.Location = new System.Drawing.Point(185, 39);
            this.btnInIf.Name = "btnInIf";
            this.btnInIf.Size = new System.Drawing.Size(167, 123);
            this.btnInIf.TabIndex = 2;
            this.btnInIf.Text = "InIf";
            this.btnInIf.UseVisualStyleBackColor = true;
            this.btnInIf.Click += new System.EventHandler(this.btnInIf_Click);
            // 
            // btnElseIf
            // 
            this.btnElseIf.Location = new System.Drawing.Point(358, 39);
            this.btnElseIf.Name = "btnElseIf";
            this.btnElseIf.Size = new System.Drawing.Size(167, 123);
            this.btnElseIf.TabIndex = 3;
            this.btnElseIf.Text = "Else If";
            this.btnElseIf.UseVisualStyleBackColor = true;
            this.btnElseIf.Click += new System.EventHandler(this.btnElseIf_Click);
            // 
            // btnAndIf
            // 
            this.btnAndIf.Location = new System.Drawing.Point(531, 39);
            this.btnAndIf.Name = "btnAndIf";
            this.btnAndIf.Size = new System.Drawing.Size(167, 123);
            this.btnAndIf.TabIndex = 4;
            this.btnAndIf.Text = "AndIf";
            this.btnAndIf.UseVisualStyleBackColor = true;
            this.btnAndIf.Click += new System.EventHandler(this.btnAndIf_Click);
            // 
            // btnOrIf
            // 
            this.btnOrIf.Location = new System.Drawing.Point(12, 168);
            this.btnOrIf.Name = "btnOrIf";
            this.btnOrIf.Size = new System.Drawing.Size(167, 123);
            this.btnOrIf.TabIndex = 5;
            this.btnOrIf.Text = "OrIf";
            this.btnOrIf.UseVisualStyleBackColor = true;
            this.btnOrIf.Click += new System.EventHandler(this.btnOrIf_Click);
            // 
            // btnBoolIf
            // 
            this.btnBoolIf.Location = new System.Drawing.Point(185, 168);
            this.btnBoolIf.Name = "btnBoolIf";
            this.btnBoolIf.Size = new System.Drawing.Size(167, 123);
            this.btnBoolIf.TabIndex = 6;
            this.btnBoolIf.Text = "BoolIf";
            this.btnBoolIf.UseVisualStyleBackColor = true;
            this.btnBoolIf.Click += new System.EventHandler(this.btnBoolIf_Click);
            // 
            // btnPM
            // 
            this.btnPM.Location = new System.Drawing.Point(358, 168);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(167, 123);
            this.btnPM.TabIndex = 7;
            this.btnPM.Text = "음수/양수 판단";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(531, 168);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(167, 123);
            this.btn.TabIndex = 8;
            this.btn.Text = "홀수/짝수 판단";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(12, 297);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(167, 123);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "삼항 연산자";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // Chap11_BranchingStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnBoolIf);
            this.Controls.Add(this.btnOrIf);
            this.Controls.Add(this.btnAndIf);
            this.Controls.Add(this.btnElseIf);
            this.Controls.Add(this.btnInIf);
            this.Controls.Add(this.txtBS);
            this.Controls.Add(this.btnIf);
            this.Name = "Chap11_BranchingStatement";
            this.Text = "분기문 학습하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIf;
        private System.Windows.Forms.TextBox txtBS;
        private System.Windows.Forms.Button btnInIf;
        private System.Windows.Forms.Button btnElseIf;
        private System.Windows.Forms.Button btnAndIf;
        private System.Windows.Forms.Button btnOrIf;
        private System.Windows.Forms.Button btnBoolIf;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btn3;
    }
}