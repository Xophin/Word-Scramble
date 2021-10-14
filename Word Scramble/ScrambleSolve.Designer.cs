
namespace Word_Scramble
{
    partial class frmScrambleSolve
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScrambledWord = new System.Windows.Forms.Label();
            this.btnStartScramble = new System.Windows.Forms.Button();
            this.lable = new System.Windows.Forms.Label();
            this.lblHint1 = new System.Windows.Forms.Label();
            this.lblHint2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHint3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetHint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(172, 143);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(73, 38);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check Answer";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(59, 117);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(181, 20);
            this.txtAnswer.TabIndex = 1;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(11, 120);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(45, 13);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Word to Solve:";
            // 
            // lblScrambledWord
            // 
            this.lblScrambledWord.AutoSize = true;
            this.lblScrambledWord.Location = new System.Drawing.Point(96, 9);
            this.lblScrambledWord.Name = "lblScrambledWord";
            this.lblScrambledWord.Size = new System.Drawing.Size(0, 13);
            this.lblScrambledWord.TabIndex = 4;
            // 
            // btnStartScramble
            // 
            this.btnStartScramble.Location = new System.Drawing.Point(14, 143);
            this.btnStartScramble.Name = "btnStartScramble";
            this.btnStartScramble.Size = new System.Drawing.Size(73, 38);
            this.btnStartScramble.TabIndex = 5;
            this.btnStartScramble.Text = "Get Scramble";
            this.btnStartScramble.UseVisualStyleBackColor = true;
            this.btnStartScramble.Click += new System.EventHandler(this.btnStartScramble_Click);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(19, 31);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(38, 13);
            this.lable.TabIndex = 6;
            this.lable.Text = "Hint 1:";
            // 
            // lblHint1
            // 
            this.lblHint1.AutoSize = true;
            this.lblHint1.Location = new System.Drawing.Point(63, 31);
            this.lblHint1.Name = "lblHint1";
            this.lblHint1.Size = new System.Drawing.Size(0, 13);
            this.lblHint1.TabIndex = 7;
            // 
            // lblHint2
            // 
            this.lblHint2.AutoSize = true;
            this.lblHint2.Location = new System.Drawing.Point(63, 55);
            this.lblHint2.Name = "lblHint2";
            this.lblHint2.Size = new System.Drawing.Size(0, 13);
            this.lblHint2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hint 2:";
            // 
            // lblHint3
            // 
            this.lblHint3.AutoSize = true;
            this.lblHint3.Location = new System.Drawing.Point(63, 85);
            this.lblHint3.Name = "lblHint3";
            this.lblHint3.Size = new System.Drawing.Size(0, 13);
            this.lblHint3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hint 3:";
            // 
            // btnGetHint
            // 
            this.btnGetHint.Location = new System.Drawing.Point(93, 143);
            this.btnGetHint.Name = "btnGetHint";
            this.btnGetHint.Size = new System.Drawing.Size(73, 38);
            this.btnGetHint.TabIndex = 12;
            this.btnGetHint.Text = "Get Hint";
            this.btnGetHint.UseVisualStyleBackColor = true;
            // 
            // frmScrambleSolve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 193);
            this.Controls.Add(this.btnGetHint);
            this.Controls.Add(this.lblHint3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHint2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHint1);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.btnStartScramble);
            this.Controls.Add(this.lblScrambledWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnCheck);
            this.Name = "frmScrambleSolve";
            this.Text = "Scramble Solve";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScrambledWord;
        private System.Windows.Forms.Button btnStartScramble;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label lblHint1;
        private System.Windows.Forms.Label lblHint2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHint3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetHint;
    }
}

