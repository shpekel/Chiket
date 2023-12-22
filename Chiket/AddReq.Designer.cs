namespace Chiket
{
    partial class AddReq
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
            this.label1 = new System.Windows.Forms.Label();
            this.Responsible = new System.Windows.Forms.TextBox();
            this.Hardware = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Comments = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказчик";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Responsible
            // 
            this.Responsible.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Responsible.Location = new System.Drawing.Point(333, 139);
            this.Responsible.Name = "Responsible";
            this.Responsible.Size = new System.Drawing.Size(100, 20);
            this.Responsible.TabIndex = 1;
            // 
            // Hardware
            // 
            this.Hardware.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Hardware.Location = new System.Drawing.Point(333, 175);
            this.Hardware.Name = "Hardware";
            this.Hardware.Size = new System.Drawing.Size(100, 20);
            this.Hardware.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Оборудование";
            // 
            // Type
            // 
            this.Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Type.Location = new System.Drawing.Point(333, 210);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(100, 20);
            this.Type.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип";
            // 
            // Description
            // 
            this.Description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Description.Location = new System.Drawing.Point(333, 236);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(100, 20);
            this.Description.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Описание";
            // 
            // Comments
            // 
            this.Comments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Comments.Location = new System.Drawing.Point(333, 262);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(100, 20);
            this.Comments.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Комментарии";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(346, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(512, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hardware);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Responsible);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(400, 220);
            this.Name = "AddReq";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Responsible;
        private System.Windows.Forms.TextBox Hardware;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Comments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}