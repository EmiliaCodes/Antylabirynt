using System.Drawing;

namespace Antylabirynt
{
    partial class GameForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.gameMap = new System.Windows.Forms.DataGridView();
            this.toolbox = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chooseLevelButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameMap
            // 
            this.gameMap.AllowUserToAddRows = false;
            this.gameMap.AllowUserToDeleteRows = false;
            this.gameMap.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gameMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameMap.Location = new System.Drawing.Point(22, 121);
            this.gameMap.Margin = new System.Windows.Forms.Padding(2);
            this.gameMap.Name = "gameMap";
            this.gameMap.RowHeadersWidth = 51;
            this.gameMap.RowTemplate.Height = 24;
            this.gameMap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gameMap.Size = new System.Drawing.Size(327, 327);
            this.gameMap.TabIndex = 0;
            this.gameMap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameMap_CellClick);
            this.gameMap.SelectionChanged += new System.EventHandler(this.gameMap_SelectionChanged);
            // 
            // toolbox
            // 
            this.toolbox.BackgroundColor = System.Drawing.Color.DarkGray;
            this.toolbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toolbox.GridColor = System.Drawing.Color.DarkGray;
            this.toolbox.Location = new System.Drawing.Point(14, 55);
            this.toolbox.Margin = new System.Windows.Forms.Padding(2);
            this.toolbox.Name = "toolbox";
            this.toolbox.RowHeadersWidth = 51;
            this.toolbox.RowTemplate.Height = 24;
            this.toolbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.toolbox.Size = new System.Drawing.Size(101, 267);
            this.toolbox.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.gameTimer_tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(16, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 41);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chooseLevelButton
            // 
            this.chooseLevelButton.BackColor = System.Drawing.Color.Gray;
            this.chooseLevelButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseLevelButton.Location = new System.Drawing.Point(22, 76);
            this.chooseLevelButton.Name = "chooseLevelButton";
            this.chooseLevelButton.Size = new System.Drawing.Size(297, 40);
            this.chooseLevelButton.TabIndex = 5;
            this.chooseLevelButton.Text = "Wróć do wyboru poziomu";
            this.chooseLevelButton.UseVisualStyleBackColor = false;
            this.chooseLevelButton.Click += new System.EventHandler(this.chooseLevelButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restartButton.BackgroundImage")));
            this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restartButton.Location = new System.Drawing.Point(276, 26);
            this.restartButton.Margin = new System.Windows.Forms.Padding(0);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(43, 47);
            this.restartButton.TabIndex = 3;
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.Location = new System.Drawing.Point(221, 26);
            this.playButton.Margin = new System.Windows.Forms.Padding(0);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(43, 47);
            this.playButton.TabIndex = 2;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(22, 27);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(180, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "Antylabirynt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(339, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 82);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ilość punktów";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolbox);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(366, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 334);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dostępne elementy";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(521, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chooseLevelButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.gameMap);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.initialize);
            ((System.ComponentModel.ISupportInitialize)(this.gameMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gameMap;
        private System.Windows.Forms.DataGridView toolbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button chooseLevelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

