﻿namespace MapTracker.NET
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uxClients = new System.Windows.Forms.ComboBox();
            this.uxStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxClients
            // 
            this.uxClients.FormattingEnabled = true;
            this.uxClients.Location = new System.Drawing.Point(12, 12);
            this.uxClients.Name = "uxClients";
            this.uxClients.Size = new System.Drawing.Size(167, 21);
            this.uxClients.TabIndex = 1;
            this.uxClients.SelectedIndexChanged += new System.EventHandler(this.uxClients_SelectedIndexChanged);
            // 
            // uxStart
            // 
            this.uxStart.Location = new System.Drawing.Point(185, 12);
            this.uxStart.Name = "uxStart";
            this.uxStart.Size = new System.Drawing.Size(167, 23);
            this.uxStart.TabIndex = 11;
            this.uxStart.Text = "Start Map Tracking";
            this.uxStart.UseVisualStyleBackColor = true;
            this.uxStart.Click += new System.EventHandler(this.uxStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 146);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 199);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uxStart);
            this.Controls.Add(this.uxClients);
            this.Name = "MainForm";
            this.Text = "MapTracker.NET (under TibiaAPI)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxClients;
        private System.Windows.Forms.Button uxStart;
        private System.Windows.Forms.TextBox textBox1;
    }
}
