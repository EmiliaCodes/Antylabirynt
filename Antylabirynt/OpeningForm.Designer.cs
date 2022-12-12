namespace Antylabirynt
{
    partial class OpeningForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.button_lvl1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.poziom2_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antylabirynt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 88);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wybierz poziom!";
            // 
            // button_lvl1
            // 
            this.button_lvl1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_lvl1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lvl1.Location = new System.Drawing.Point(100, 130);
            this.button_lvl1.Name = "button_lvl1";
            this.button_lvl1.Size = new System.Drawing.Size(112, 34);
            this.button_lvl1.TabIndex = 4;
            this.button_lvl1.Text = "Poziom 1";
            this.button_lvl1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_lvl1.UseVisualStyleBackColor = false;
            this.button_lvl1.Click += new System.EventHandler(this.lvl1_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(337, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "OK";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.enableLvl);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(59, 200);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(414, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Aby odblokować wyższe poziomy wpisz hasło!";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordBox.Location = new System.Drawing.Point(115, 248);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(197, 29);
            this.passwordBox.TabIndex = 1;
            // 
            // poziom2_button
            // 
            this.poziom2_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.poziom2_button.Enabled = false;
            this.poziom2_button.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poziom2_button.Location = new System.Drawing.Point(231, 130);
            this.poziom2_button.Name = "poziom2_button";
            this.poziom2_button.Size = new System.Drawing.Size(112, 34);
            this.poziom2_button.TabIndex = 6;
            this.poziom2_button.Text = "Poziom 2";
            this.poziom2_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.poziom2_button.UseVisualStyleBackColor = false;
            this.poziom2_button.Click += new System.EventHandler(this.lvl2_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(361, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "Poziom 3";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.lvl3_click);
            // 
            // OpeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(537, 305);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.poziom2_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_lvl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label1);
            this.Name = "OpeningForm";
            this.Text = "Antylabirynt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_lvl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button poziom2_button;
        private System.Windows.Forms.Button button3;
    }
}