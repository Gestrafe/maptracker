﻿namespace MapTracker
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
            this.uxStart = new System.Windows.Forms.Button();
            this.uxWrite = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uxLog = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uxMapBoundsSE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uxTrackedMapSize = new System.Windows.Forms.TextBox();
            this.uxMapBoundsNW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxTrackedItems = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxTrackedTiles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uxTrackMovable = new System.Windows.Forms.CheckBox();
            this.uxTrackCurrentFloor = new System.Windows.Forms.CheckBox();
            this.uxTrackSplashes = new System.Windows.Forms.CheckBox();
            this.uxTrackFromCam = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxStart
            // 
            this.uxStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStart.Location = new System.Drawing.Point(259, 12);
            this.uxStart.Name = "uxStart";
            this.uxStart.Size = new System.Drawing.Size(166, 44);
            this.uxStart.TabIndex = 11;
            this.uxStart.Text = "Start Map Tracking";
            this.uxStart.UseVisualStyleBackColor = true;
            this.uxStart.Click += new System.EventHandler(this.uxStart_Click);
            // 
            // uxWrite
            // 
            this.uxWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWrite.Location = new System.Drawing.Point(258, 210);
            this.uxWrite.Name = "uxWrite";
            this.uxWrite.Size = new System.Drawing.Size(166, 44);
            this.uxWrite.TabIndex = 11;
            this.uxWrite.Text = "Write to File";
            this.uxWrite.UseVisualStyleBackColor = true;
            this.uxWrite.Click += new System.EventHandler(this.uxWrite_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.uxLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 187);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // uxLog
            // 
            this.uxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxLog.Location = new System.Drawing.Point(3, 16);
            this.uxLog.Multiline = true;
            this.uxLog.Name = "uxLog";
            this.uxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uxLog.Size = new System.Drawing.Size(406, 168);
            this.uxLog.TabIndex = 13;
            this.uxLog.Text = resources.GetString("uxLog.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uxMapBoundsSE);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.uxTrackedMapSize);
            this.groupBox2.Controls.Add(this.uxMapBoundsNW);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.uxTrackedItems);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.uxTrackedTiles);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 155);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics";
            // 
            // uxMapBoundsSE
            // 
            this.uxMapBoundsSE.Location = new System.Drawing.Point(107, 121);
            this.uxMapBoundsSE.Name = "uxMapBoundsSE";
            this.uxMapBoundsSE.ReadOnly = true;
            this.uxMapBoundsSE.Size = new System.Drawing.Size(127, 20);
            this.uxMapBoundsSE.TabIndex = 3;
            this.uxMapBoundsSE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Map bounds SE:";
            // 
            // uxTrackedMapSize
            // 
            this.uxTrackedMapSize.Location = new System.Drawing.Point(107, 69);
            this.uxTrackedMapSize.Name = "uxTrackedMapSize";
            this.uxTrackedMapSize.ReadOnly = true;
            this.uxTrackedMapSize.Size = new System.Drawing.Size(127, 20);
            this.uxTrackedMapSize.TabIndex = 3;
            this.uxTrackedMapSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxMapBoundsNW
            // 
            this.uxMapBoundsNW.Location = new System.Drawing.Point(107, 95);
            this.uxMapBoundsNW.Name = "uxMapBoundsNW";
            this.uxMapBoundsNW.ReadOnly = true;
            this.uxMapBoundsNW.Size = new System.Drawing.Size(127, 20);
            this.uxMapBoundsNW.TabIndex = 1;
            this.uxMapBoundsNW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tracked map size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Map bounds NW:";
            // 
            // uxTrackedItems
            // 
            this.uxTrackedItems.Location = new System.Drawing.Point(107, 43);
            this.uxTrackedItems.Name = "uxTrackedItems";
            this.uxTrackedItems.ReadOnly = true;
            this.uxTrackedItems.Size = new System.Drawing.Size(127, 20);
            this.uxTrackedItems.TabIndex = 1;
            this.uxTrackedItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tracked Items:";
            // 
            // uxTrackedTiles
            // 
            this.uxTrackedTiles.Location = new System.Drawing.Point(107, 17);
            this.uxTrackedTiles.Name = "uxTrackedTiles";
            this.uxTrackedTiles.ReadOnly = true;
            this.uxTrackedTiles.Size = new System.Drawing.Size(127, 20);
            this.uxTrackedTiles.TabIndex = 1;
            this.uxTrackedTiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tracked Tiles:";
            // 
            // uxReset
            // 
            this.uxReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReset.Location = new System.Drawing.Point(259, 78);
            this.uxReset.Name = "uxReset";
            this.uxReset.Size = new System.Drawing.Size(166, 44);
            this.uxReset.TabIndex = 12;
            this.uxReset.Text = "Reset";
            this.uxReset.UseVisualStyleBackColor = true;
            this.uxReset.Click += new System.EventHandler(this.uxReset_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.uxTrackMovable);
            this.groupBox3.Controls.Add(this.uxTrackCurrentFloor);
            this.groupBox3.Controls.Add(this.uxTrackSplashes);
            this.groupBox3.Location = new System.Drawing.Point(15, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 86);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // uxTrackMovable
            // 
            this.uxTrackMovable.AutoSize = true;
            this.uxTrackMovable.Location = new System.Drawing.Point(7, 19);
            this.uxTrackMovable.Name = "uxTrackMovable";
            this.uxTrackMovable.Size = new System.Drawing.Size(124, 17);
            this.uxTrackMovable.TabIndex = 0;
            this.uxTrackMovable.Text = "Track movable items";
            this.uxTrackMovable.UseVisualStyleBackColor = true;
            // 
            // uxTrackCurrentFloor
            // 
            this.uxTrackCurrentFloor.AutoSize = true;
            this.uxTrackCurrentFloor.Location = new System.Drawing.Point(7, 61);
            this.uxTrackCurrentFloor.Name = "uxTrackCurrentFloor";
            this.uxTrackCurrentFloor.Size = new System.Drawing.Size(135, 17);
            this.uxTrackCurrentFloor.TabIndex = 0;
            this.uxTrackCurrentFloor.Text = "Track current floor only";
            this.uxTrackCurrentFloor.UseVisualStyleBackColor = true;
            // 
            // uxTrackSplashes
            // 
            this.uxTrackSplashes.AutoSize = true;
            this.uxTrackSplashes.Location = new System.Drawing.Point(7, 40);
            this.uxTrackSplashes.Name = "uxTrackSplashes";
            this.uxTrackSplashes.Size = new System.Drawing.Size(98, 17);
            this.uxTrackSplashes.TabIndex = 0;
            this.uxTrackSplashes.Text = "Track splashes";
            this.uxTrackSplashes.UseVisualStyleBackColor = true;
            // 
            // uxTrackFromCam
            // 
            this.uxTrackFromCam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTrackFromCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTrackFromCam.Location = new System.Drawing.Point(259, 144);
            this.uxTrackFromCam.Name = "uxTrackFromCam";
            this.uxTrackFromCam.Size = new System.Drawing.Size(166, 44);
            this.uxTrackFromCam.TabIndex = 12;
            this.uxTrackFromCam.Text = "Track from CAM...";
            this.uxTrackFromCam.UseVisualStyleBackColor = true;
            this.uxTrackFromCam.Click += new System.EventHandler(this.uxTrackFromCam_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 459);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.uxTrackFromCam);
            this.Controls.Add(this.uxReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uxWrite);
            this.Controls.Add(this.uxStart);
            this.Name = "MainForm";
            this.Text = "MapTracker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxStart;
        private System.Windows.Forms.Button uxWrite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox uxLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox uxTrackedTiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxTrackedItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxReset;
        private System.Windows.Forms.TextBox uxTrackedMapSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox uxTrackMovable;
        private System.Windows.Forms.CheckBox uxTrackCurrentFloor;
        private System.Windows.Forms.CheckBox uxTrackSplashes;
        private System.Windows.Forms.TextBox uxMapBoundsSE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uxMapBoundsNW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uxTrackFromCam;
    }
}

