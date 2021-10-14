
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
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(99, 63);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(73, 38);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check Answer";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(60, 37);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(181, 20);
            this.txtAnswer.TabIndex = 1;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(12, 40);
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
            this.btnStartScramble.Location = new System.Drawing.Point(15, 63);
            this.btnStartScramble.Name = "btnStartScramble";
            this.btnStartScramble.Size = new System.Drawing.Size(73, 38);
            this.btnStartScramble.TabIndex = 5;
            this.btnStartScramble.Text = "Get Scramble";
            this.btnStartScramble.UseVisualStyleBackColor = true;
            this.btnStartScramble.Click += new System.EventHandler(this.btnStartScramble_Click);
            // 
            // frmScrambleSolve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 114);
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
    }
}

