﻿namespace MyFirstCSharp
{
    partial class Chap04_DataType_ConvTest
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
            this.txtFirtValue = new System.Windows.Forms.TextBox();
            this.txtSecValue = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "아래 텍스트 박스에 입력한 두 수의 합을 메세지 박스로 표현 하세요.\r\n* 숫자만 입력 한다고 가정\r\n";
            // 
            // txtFirtValue
            // 
            this.txtFirtValue.Location = new System.Drawing.Point(136, 120);
            this.txtFirtValue.Name = "txtFirtValue";
            this.txtFirtValue.Size = new System.Drawing.Size(97, 21);
            this.txtFirtValue.TabIndex = 1;
            // 
            // txtSecValue
            // 
            this.txtSecValue.Location = new System.Drawing.Point(276, 120);
            this.txtSecValue.Name = "txtSecValue";
            this.txtSecValue.Size = new System.Drawing.Size(97, 21);
            this.txtSecValue.TabIndex = 2;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(411, 120);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(96, 21);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "더하기";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // Chap04_DataType_ConvTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 237);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtSecValue);
            this.Controls.Add(this.txtFirtValue);
            this.Controls.Add(this.label1);
            this.Name = "Chap04_DataType_ConvTest";
            this.Text = "데이터 형 변환 텍스트";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirtValue;
        private System.Windows.Forms.TextBox txtSecValue;
        private System.Windows.Forms.Button btnSum;
    }
}