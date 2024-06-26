﻿namespace Clicker
{
    partial class FormClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClicker));
            buttonClick = new Button();
            pictureBoxCount = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCount).BeginInit();
            SuspendLayout();
            // 
            // buttonClick
            // 
            buttonClick.BackgroundImage = Properties.Resources.apple;
            buttonClick.BackgroundImageLayout = ImageLayout.Zoom;
            buttonClick.FlatAppearance.BorderColor = SystemColors.Control;
            buttonClick.FlatAppearance.BorderSize = 0;
            buttonClick.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            buttonClick.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            buttonClick.FlatStyle = FlatStyle.Flat;
            buttonClick.Location = new Point(193, 93);
            buttonClick.Name = "buttonClick";
            buttonClick.Size = new Size(415, 239);
            buttonClick.TabIndex = 0;
            buttonClick.UseVisualStyleBackColor = false;
            buttonClick.Click += buttonClick_Click;
            // 
            // pictureBoxCount
            // 
            pictureBoxCount.Location = new Point(346, 37);
            pictureBoxCount.Name = "pictureBoxCount";
            pictureBoxCount.Size = new Size(100, 50);
            pictureBoxCount.TabIndex = 1;
            pictureBoxCount.TabStop = false;
            // 
            // FormClicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(pictureBoxCount);
            Controls.Add(buttonClick);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "FormClicker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apple";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonClick;
        private PictureBox pictureBoxCount;
    }
}