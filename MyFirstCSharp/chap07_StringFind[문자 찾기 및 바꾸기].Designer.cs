namespace MyFirstCSharp
{
    partial class chap07_StringFind
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.txtIndexOf = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btbLastIndex = new System.Windows.Forms.Button();
            this.txtLastIndexOf = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStartWith = new System.Windows.Forms.Button();
            this.txtStartWith = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEndWith = new System.Windows.Forms.Button();
            this.txtEndWith = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnContains = new System.Windows.Forms.Button();
            this.txtContains = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(25, 38);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(373, 12);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "동해물과 백두산이 마르고 닳도록 하는님이 보우하사 우리 나라 만세";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIndexOf);
            this.groupBox1.Controls.Add(this.txtIndexOf);
            this.groupBox1.Location = new System.Drawing.Point(27, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "indexOf()";
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(3, 66);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(171, 25);
            this.btnIndexOf.TabIndex = 1;
            this.btnIndexOf.Text = "찾기";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // txtIndexOf
            // 
            this.txtIndexOf.Location = new System.Drawing.Point(3, 23);
            this.txtIndexOf.Name = "txtIndexOf";
            this.txtIndexOf.Size = new System.Drawing.Size(172, 21);
            this.txtIndexOf.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btbLastIndex);
            this.groupBox2.Controls.Add(this.txtLastIndexOf);
            this.groupBox2.Location = new System.Drawing.Point(232, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 101);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LastIndexOf()";
            // 
            // btbLastIndex
            // 
            this.btbLastIndex.Location = new System.Drawing.Point(3, 66);
            this.btbLastIndex.Name = "btbLastIndex";
            this.btbLastIndex.Size = new System.Drawing.Size(171, 25);
            this.btbLastIndex.TabIndex = 1;
            this.btbLastIndex.Text = "찾기";
            this.btbLastIndex.UseVisualStyleBackColor = true;
            this.btbLastIndex.Click += new System.EventHandler(this.btbLastIndex_Click);
            // 
            // txtLastIndexOf
            // 
            this.txtLastIndexOf.Location = new System.Drawing.Point(3, 23);
            this.txtLastIndexOf.Name = "txtLastIndexOf";
            this.txtLastIndexOf.Size = new System.Drawing.Size(172, 21);
            this.txtLastIndexOf.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStartWith);
            this.groupBox3.Controls.Add(this.txtStartWith);
            this.groupBox3.Location = new System.Drawing.Point(437, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 101);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "StartWith()";
            // 
            // btnStartWith
            // 
            this.btnStartWith.Location = new System.Drawing.Point(3, 66);
            this.btnStartWith.Name = "btnStartWith";
            this.btnStartWith.Size = new System.Drawing.Size(171, 25);
            this.btnStartWith.TabIndex = 1;
            this.btnStartWith.Text = "판단하기";
            this.btnStartWith.UseVisualStyleBackColor = true;
            this.btnStartWith.Click += new System.EventHandler(this.btnStartWith_Click);
            // 
            // txtStartWith
            // 
            this.txtStartWith.Location = new System.Drawing.Point(3, 23);
            this.txtStartWith.Name = "txtStartWith";
            this.txtStartWith.Size = new System.Drawing.Size(172, 21);
            this.txtStartWith.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEndWith);
            this.groupBox4.Controls.Add(this.txtEndWith);
            this.groupBox4.Location = new System.Drawing.Point(642, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 101);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "EndWith()";
            // 
            // btnEndWith
            // 
            this.btnEndWith.Location = new System.Drawing.Point(3, 66);
            this.btnEndWith.Name = "btnEndWith";
            this.btnEndWith.Size = new System.Drawing.Size(171, 25);
            this.btnEndWith.TabIndex = 1;
            this.btnEndWith.Text = "판단하기";
            this.btnEndWith.UseVisualStyleBackColor = true;
            this.btnEndWith.Click += new System.EventHandler(this.btnEndWith_Click);
            // 
            // txtEndWith
            // 
            this.txtEndWith.Location = new System.Drawing.Point(3, 23);
            this.txtEndWith.Name = "txtEndWith";
            this.txtEndWith.Size = new System.Drawing.Size(172, 21);
            this.txtEndWith.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnContains);
            this.groupBox5.Controls.Add(this.txtContains);
            this.groupBox5.Location = new System.Drawing.Point(27, 217);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(199, 101);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cantains()";
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(3, 66);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(171, 25);
            this.btnContains.TabIndex = 1;
            this.btnContains.Text = "판단하기";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // txtContains
            // 
            this.txtContains.Location = new System.Drawing.Point(3, 23);
            this.txtContains.Name = "txtContains";
            this.txtContains.Size = new System.Drawing.Size(172, 21);
            this.txtContains.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtAfter);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.btnReplace);
            this.groupBox6.Controls.Add(this.txtBefore);
            this.groupBox6.Location = new System.Drawing.Point(235, 217);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(606, 101);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Replace()";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(3, 66);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(171, 25);
            this.btnReplace.TabIndex = 1;
            this.btnReplace.Text = "바꾸기";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // txtBefore
            // 
            this.txtBefore.Location = new System.Drawing.Point(106, 23);
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.Size = new System.Drawing.Size(109, 21);
            this.txtBefore.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "변경 전 문자열";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "변경 후 문자열";
            // 
            // txtAfter
            // 
            this.txtAfter.Location = new System.Drawing.Point(380, 23);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(109, 21);
            this.txtAfter.TabIndex = 4;
            // 
            // chap07_StringFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTitle);
            this.Name = "chap07_StringFind";
            this.Text = "문자열 찾기 및 바꾸기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.TextBox txtIndexOf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btbLastIndex;
        private System.Windows.Forms.TextBox txtLastIndexOf;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStartWith;
        private System.Windows.Forms.TextBox txtStartWith;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEndWith;
        private System.Windows.Forms.TextBox txtEndWith;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.TextBox txtContains;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}