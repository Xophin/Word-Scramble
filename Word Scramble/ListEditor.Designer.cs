
namespace Word_Scramble
{
    partial class ListEditor
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
            this.clbAvailableLists = new System.Windows.Forms.CheckedListBox();
            this.rtxtListPreview = new System.Windows.Forms.RichTextBox();
            this.btnAddNewList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbAvailableLists
            // 
            this.clbAvailableLists.FormattingEnabled = true;
            this.clbAvailableLists.Location = new System.Drawing.Point(12, 12);
            this.clbAvailableLists.Name = "clbAvailableLists";
            this.clbAvailableLists.Size = new System.Drawing.Size(193, 184);
            this.clbAvailableLists.TabIndex = 0;
            // 
            // rtxtListPreview
            // 
            this.rtxtListPreview.Location = new System.Drawing.Point(260, 19);
            this.rtxtListPreview.Name = "rtxtListPreview";
            this.rtxtListPreview.ReadOnly = true;
            this.rtxtListPreview.Size = new System.Drawing.Size(229, 176);
            this.rtxtListPreview.TabIndex = 1;
            this.rtxtListPreview.Text = "";
            // 
            // btnAddNewList
            // 
            this.btnAddNewList.Location = new System.Drawing.Point(14, 205);
            this.btnAddNewList.Name = "btnAddNewList";
            this.btnAddNewList.Size = new System.Drawing.Size(71, 40);
            this.btnAddNewList.TabIndex = 2;
            this.btnAddNewList.Text = "Add List From Text File";
            this.btnAddNewList.UseVisualStyleBackColor = true;
            // 
            // frmListSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 319);
            this.Controls.Add(this.btnAddNewList);
            this.Controls.Add(this.rtxtListPreview);
            this.Controls.Add(this.clbAvailableLists);
            this.Name = "frmListSelector";
            this.Text = "Select Lists to Include";
            this.Load += new System.EventHandler(this.frmListSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbAvailableLists;
        private System.Windows.Forms.RichTextBox rtxtListPreview;
        private System.Windows.Forms.Button btnAddNewList;
    }
}