﻿namespace Chiket
{
    partial class Main
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
            this.CheckReq = new System.Windows.Forms.Button();
            this.AddReq = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckReq
            // 
            this.CheckReq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckReq.Location = new System.Drawing.Point(363, 131);
            this.CheckReq.Name = "CheckReq";
            this.CheckReq.Size = new System.Drawing.Size(121, 23);
            this.CheckReq.TabIndex = 0;
            this.CheckReq.Text = "Посмотреть заявки";
            this.CheckReq.UseVisualStyleBackColor = true;
            this.CheckReq.Click += new System.EventHandler(this.CheckReq_Click);
            // 
            // AddReq
            // 
            this.AddReq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddReq.Location = new System.Drawing.Point(363, 183);
            this.AddReq.Name = "AddReq";
            this.AddReq.Size = new System.Drawing.Size(121, 23);
            this.AddReq.TabIndex = 1;
            this.AddReq.Text = "Добавить";
            this.AddReq.UseVisualStyleBackColor = true;
            this.AddReq.Click += new System.EventHandler(this.AddReq_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddReq);
            this.Controls.Add(this.CheckReq);
            this.MinimumSize = new System.Drawing.Size(400, 220);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CheckReq;
        private System.Windows.Forms.Button AddReq;
        private System.Windows.Forms.Button button1;
    }
}