namespace ClickerGame
{
    partial class AchievementsForm
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
            this.ListBoxA = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RTBDescription = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxA
            // 
            this.ListBoxA.FormattingEnabled = true;
            this.ListBoxA.Location = new System.Drawing.Point(12, 12);
            this.ListBoxA.Name = "ListBoxA";
            this.ListBoxA.Size = new System.Drawing.Size(195, 95);
            this.ListBoxA.TabIndex = 0;
            this.ListBoxA.SelectedIndexChanged += new System.EventHandler(this.ListBoxA_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RTBDescription);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // RTBDescription
            // 
            this.RTBDescription.Location = new System.Drawing.Point(6, 19);
            this.RTBDescription.Name = "RTBDescription";
            this.RTBDescription.ReadOnly = true;
            this.RTBDescription.Size = new System.Drawing.Size(183, 115);
            this.RTBDescription.TabIndex = 0;
            this.RTBDescription.Text = "";
            // 
            // AchievementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 265);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListBoxA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AchievementsForm";
            this.Text = "AchievementsForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox RTBDescription;
    }
}