namespace MyFirstCSharp
{
    partial class Chap09_StringManage_Test
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
            this.LbTitle = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbTitle.Location = new System.Drawing.Point(22, 21);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(1125, 23);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "안녕하세요 2023 제조혁신 인재양성 S/W 개발 교육과정을 이수하게 된 OOO  입니다. 즐겁고 보람찬 DIGITALTRANING 교육이 되었으" +
    "면 합니다.";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(26, 90);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(205, 72);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "OOO -> 본인 이름으로 변경\r\n*라벨 Text에 직접 표현";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(237, 90);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(205, 72);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "\"S/W\" 의 위치 찾고 메세지박스\r\n*구현은  in Line으로";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(448, 90);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(205, 72);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "시작 단어와 마지막 단어 각각 1자씩 메세지로 표현";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(26, 168);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(205, 72);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "타이틀 문자열의 앞, 뒤에 \r\n\"-DT-\" 문자열 삽입\r\n*라벨 Text에 직접 표현";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(237, 168);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(205, 72);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "DIGITALTRAING만 소문자로 변경\r\n*DIGITALTRAING 문자는 고정\r\n*라벨 Text에 직접 표현\r\n";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(448, 168);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(205, 72);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "타이틀 문자열의 모든 공백 없애기\r\n*라벨 Text에 직접 표현";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(26, 281);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(627, 72);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "원본 문자열 되돌리기";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // Chap09_StringManage_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 450);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.LbTitle);
            this.Name = "Chap09_StringManage_Test";
            this.Text = "문자열 다루기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
    }
}