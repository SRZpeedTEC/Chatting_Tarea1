namespace Chatting
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
            this.tittle = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.TextBox();
            this.portText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.portUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tittle
            // 
            this.tittle.AutoEllipsis = true;
            this.tittle.AutoSize = true;
            this.tittle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tittle.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tittle.Location = new System.Drawing.Point(228, 20);
            this.tittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(351, 60);
            this.tittle.TabIndex = 0;
            this.tittle.Text = "Chatting App";
            this.tittle.Click += new System.EventHandler(this.label1_Click);
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(139, 248);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(285, 22);
            this.messageText.TabIndex = 1;
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(215, 363);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(124, 22);
            this.portText.TabIndex = 2;
            this.portText.TextChanged += new System.EventHandler(this.portText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(100, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese su mensaje";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(171, 323);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Puerto de llegada";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.Color.LightSlateGray;
            this.buttonSend.Location = new System.Drawing.Point(153, 449);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(233, 60);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "Enviar Mensaje";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(609, 236);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(380, 337);
            this.chatBox.TabIndex = 1;
            this.chatBox.TextChanged += new System.EventHandler(this.chat_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(712, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chat con";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // portUser
            // 
            this.portUser.Location = new System.Drawing.Point(729, 99);
            this.portUser.Name = "portUser";
            this.portUser.ReadOnly = true;
            this.portUser.Size = new System.Drawing.Size(132, 22);
            this.portUser.TabIndex = 9;
            this.portUser.TextChanged += new System.EventHandler(this.portUser_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(722, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Usuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1084, 642);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.portUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.tittle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox portUser;
        private System.Windows.Forms.Label label4;
    }
}

