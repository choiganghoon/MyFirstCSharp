namespace MyFirstCSharp
{
    partial class Chap12_IF_Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chap12_IF_Test));
            this.label23 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn25 = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(134, 45);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 12);
            this.label23.TabIndex = 0;
            this.label23.Text = "입력 받을 값";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(213, 42);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(195, 21);
            this.txt1.TabIndex = 1;
            // 
            // btn25
            // 
            this.btn25.Location = new System.Drawing.Point(412, 42);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(159, 19);
            this.btn25.TabIndex = 2;
            this.btn25.Text = "2, 5의 공배수 인지 판단";
            this.btn25.UseVisualStyleBackColor = true;
            this.btn25.Click += new System.EventHandler(this.btn25_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(213, 82);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(195, 21);
            this.txt2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "8의 배수일 경우 값과의 곱";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(213, 119);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(195, 21);
            this.txt3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "버튼을 클릭한 총 횟수";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 144);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Chap12_IF_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn25);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label23);
            this.Name = "Chap12_IF_Test";
            this.Text = "분기문 IF 실습";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}