namespace ClickerGame
{
    partial class Form1
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
            this.LabelPoints = new System.Windows.Forms.Label();
            this.ButtonClick = new System.Windows.Forms.Button();
            this.ListBoxUpgrades = new System.Windows.Forms.ListBox();
            this.ButtonUpgradeBuy = new System.Windows.Forms.Button();
            this.Upgrades = new System.Windows.Forms.GroupBox();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.LabelQuote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.achievementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Upgrades.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelPoints
            // 
            this.LabelPoints.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPoints.Location = new System.Drawing.Point(13, 32);
            this.LabelPoints.Name = "LabelPoints";
            this.LabelPoints.Size = new System.Drawing.Size(135, 24);
            this.LabelPoints.TabIndex = 0;
            this.LabelPoints.Text = "0";
            this.LabelPoints.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonClick
            // 
            this.ButtonClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClick.Location = new System.Drawing.Point(12, 415);
            this.ButtonClick.Name = "ButtonClick";
            this.ButtonClick.Size = new System.Drawing.Size(135, 23);
            this.ButtonClick.TabIndex = 1;
            this.ButtonClick.Text = "Button Click";
            this.ButtonClick.UseVisualStyleBackColor = true;
            this.ButtonClick.Click += new System.EventHandler(this.ButtonClick_Click);
            // 
            // ListBoxUpgrades
            // 
            this.ListBoxUpgrades.FormattingEnabled = true;
            this.ListBoxUpgrades.Location = new System.Drawing.Point(6, 21);
            this.ListBoxUpgrades.Name = "ListBoxUpgrades";
            this.ListBoxUpgrades.Size = new System.Drawing.Size(120, 95);
            this.ListBoxUpgrades.TabIndex = 2;
            // 
            // ButtonUpgradeBuy
            // 
            this.ButtonUpgradeBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpgradeBuy.Location = new System.Drawing.Point(29, 122);
            this.ButtonUpgradeBuy.Name = "ButtonUpgradeBuy";
            this.ButtonUpgradeBuy.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpgradeBuy.TabIndex = 3;
            this.ButtonUpgradeBuy.Text = "Buy";
            this.ButtonUpgradeBuy.UseVisualStyleBackColor = true;
            this.ButtonUpgradeBuy.Click += new System.EventHandler(this.ButtonUpgradeBuy_Click);
            // 
            // Upgrades
            // 
            this.Upgrades.Controls.Add(this.ListBoxUpgrades);
            this.Upgrades.Controls.Add(this.ButtonUpgradeBuy);
            this.Upgrades.Location = new System.Drawing.Point(12, 242);
            this.Upgrades.Name = "Upgrades";
            this.Upgrades.Size = new System.Drawing.Size(135, 154);
            this.Upgrades.TabIndex = 4;
            this.Upgrades.TabStop = false;
            this.Upgrades.Text = "Upgrades";
            // 
            // ButtonClear
            // 
            this.ButtonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClear.Location = new System.Drawing.Point(13, 59);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(135, 23);
            this.ButtonClear.TabIndex = 5;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // LabelQuote
            // 
            this.LabelQuote.Location = new System.Drawing.Point(13, 85);
            this.LabelQuote.Name = "LabelQuote";
            this.LabelQuote.Size = new System.Drawing.Size(134, 33);
            this.LabelQuote.TabIndex = 6;
            this.LabelQuote.Text = "Quote";
            this.LabelQuote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Press R to reload LUA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.achievementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(168, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // achievementToolStripMenuItem
            // 
            this.achievementToolStripMenuItem.Name = "achievementToolStripMenuItem";
            this.achievementToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.achievementToolStripMenuItem.Text = "&Achievements";
            this.achievementToolStripMenuItem.Click += new System.EventHandler(this.achievementToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelQuote);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.Upgrades);
            this.Controls.Add(this.ButtonClick);
            this.Controls.Add(this.LabelPoints);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Upgrades.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPoints;
        private System.Windows.Forms.Button ButtonClick;
        private System.Windows.Forms.ListBox ListBoxUpgrades;
        private System.Windows.Forms.Button ButtonUpgradeBuy;
        private System.Windows.Forms.GroupBox Upgrades;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Label LabelQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem achievementToolStripMenuItem;
    }
}

