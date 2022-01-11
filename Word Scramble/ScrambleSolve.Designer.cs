﻿
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetHint = new System.Windows.Forms.Button();
            this.btnListEditor = new System.Windows.Forms.Button();
            this.txtHint1 = new System.Windows.Forms.TextBox();
            this.txtHint2 = new System.Windows.Forms.TextBox();
            this.txtHint3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.AccessibleDescription = "Checks the user\'s imputted answer to see if it is correct.";
            this.btnCheck.AccessibleName = "Check Answer";
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
            this.label2.AccessibleDescription = "The label that appears before the word to solve.";
            this.label2.AccessibleName = "Word to Solve label";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Word to Solve:";
            // 
            // lblScrambledWord
            // 
            this.lblScrambledWord.AccessibleDescription = "This is where the word to solve pops up, I should change this to be the actual sc" +
    "rambled word.";
            this.lblScrambledWord.AccessibleName = "The scrambled word.";
            this.lblScrambledWord.AutoSize = true;
            this.lblScrambledWord.Location = new System.Drawing.Point(96, 9);
            this.lblScrambledWord.Name = "lblScrambledWord";
            this.lblScrambledWord.Size = new System.Drawing.Size(0, 13);
            this.lblScrambledWord.TabIndex = 4;
            // 
            // btnStartScramble
            // 
            this.btnStartScramble.AccessibleDescription = "Gives the user a new word to unscramble.";
            this.btnStartScramble.AccessibleName = "New Scramble";
            this.btnStartScramble.Location = new System.Drawing.Point(14, 143);
            this.btnStartScramble.Name = "btnStartScramble";
            this.btnStartScramble.Size = new System.Drawing.Size(73, 38);
            this.btnStartScramble.TabIndex = 5;
            this.btnStartScramble.Text = "New Scramble";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hint 2:";
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
            this.btnGetHint.AccessibleDescription = "Reveals one of the hints for a scrambled word.";
            this.btnGetHint.AccessibleName = "Get Hint";
            this.btnGetHint.Location = new System.Drawing.Point(93, 143);
            this.btnGetHint.Name = "btnGetHint";
            this.btnGetHint.Size = new System.Drawing.Size(73, 38);
            this.btnGetHint.TabIndex = 12;
            this.btnGetHint.Text = "Get Hint";
            this.btnGetHint.UseVisualStyleBackColor = true;
            this.btnGetHint.Click += new System.EventHandler(this.btnGetHint_Click);
            // 
            // btnListEditor
            // 
            this.btnListEditor.Location = new System.Drawing.Point(14, 187);
            this.btnListEditor.Name = "btnListEditor";
            this.btnListEditor.Size = new System.Drawing.Size(73, 38);
            this.btnListEditor.TabIndex = 13;
            this.btnListEditor.Text = "List Editor";
            this.btnListEditor.UseVisualStyleBackColor = true;
            this.btnListEditor.Click += new System.EventHandler(this.btnListEditor_Click);
            // 
            // txtHint1
            // 
            this.txtHint1.AccessibleName = "Hint 1 Description box";
            this.txtHint1.Location = new System.Drawing.Point(63, 25);
            this.txtHint1.Name = "txtHint1";
            this.txtHint1.Size = new System.Drawing.Size(177, 20);
            this.txtHint1.TabIndex = 14;
            // 
            // txtHint2
            // 
            this.txtHint2.Location = new System.Drawing.Point(63, 55);
            this.txtHint2.Name = "txtHint2";
            this.txtHint2.Size = new System.Drawing.Size(177, 20);
            this.txtHint2.TabIndex = 15;
            // 
            // txtHint3
            // 
            this.txtHint3.Location = new System.Drawing.Point(64, 82);
            this.txtHint3.Name = "txtHint3";
            this.txtHint3.Size = new System.Drawing.Size(177, 20);
            this.txtHint3.TabIndex = 16;
            // 
            // frmScrambleSolve
            // 
            this.AccessibleDescription = "The screen for solving the scrambled word, viewing the hints, and checking the an" +
    "swer.";
            this.AccessibleName = "Scramble Solve.";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 267);
            this.Controls.Add(this.txtHint3);
            this.Controls.Add(this.txtHint2);
            this.Controls.Add(this.txtHint1);
            this.Controls.Add(this.btnListEditor);
            this.Controls.Add(this.btnGetHint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetHint;
        private System.Windows.Forms.Button btnListEditor;
        private System.Windows.Forms.TextBox txtHint1;
        private System.Windows.Forms.TextBox txtHint2;
        private System.Windows.Forms.TextBox txtHint3;
    }
}

