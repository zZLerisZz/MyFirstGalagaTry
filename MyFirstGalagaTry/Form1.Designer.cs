namespace MyFirstGalagaTry
{
    partial class App
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.RecordsButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.MenuName = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.PlayerSprite = new System.Windows.Forms.PictureBox();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.BackToMenuFromSettings = new System.Windows.Forms.Button();
            this.RecordsPanel = new System.Windows.Forms.Panel();
            this.BackToMenuFromRecords = new System.Windows.Forms.Button();
            this.TickTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuPanel.SuspendLayout();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSprite)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            this.RecordsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuPanel.BackgroundImage")));
            this.MenuPanel.Controls.Add(this.RecordsButton);
            this.MenuPanel.Controls.Add(this.SettingsButton);
            this.MenuPanel.Controls.Add(this.ExitButton);
            this.MenuPanel.Controls.Add(this.PlayButton);
            this.MenuPanel.Controls.Add(this.MenuName);
            this.MenuPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1707, 886);
            this.MenuPanel.TabIndex = 0;
            // 
            // RecordsButton
            // 
            this.RecordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordsButton.Location = new System.Drawing.Point(439, 399);
            this.RecordsButton.Margin = new System.Windows.Forms.Padding(4);
            this.RecordsButton.Name = "RecordsButton";
            this.RecordsButton.Size = new System.Drawing.Size(385, 78);
            this.RecordsButton.TabIndex = 8;
            this.RecordsButton.TabStop = false;
            this.RecordsButton.Text = "Рекорды";
            this.RecordsButton.UseVisualStyleBackColor = true;
            this.RecordsButton.Click += new System.EventHandler(this.RecordsButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.Location = new System.Drawing.Point(439, 277);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(385, 78);
            this.SettingsButton.TabIndex = 7;
            this.SettingsButton.TabStop = false;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(439, 511);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(385, 78);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.Location = new System.Drawing.Point(439, 166);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(385, 78);
            this.PlayButton.TabIndex = 6;
            this.PlayButton.TabStop = false;
            this.PlayButton.Text = "Играть";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // MenuName
            // 
            this.MenuName.AutoSize = true;
            this.MenuName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuName.Location = new System.Drawing.Point(510, 46);
            this.MenuName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MenuName.Name = "MenuName";
            this.MenuName.Size = new System.Drawing.Size(223, 69);
            this.MenuName.TabIndex = 5;
            this.MenuName.Text = "МЕНЮ";
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GamePanel.Controls.Add(this.PlayerSprite);
            this.GamePanel.Controls.Add(this.BackToMenu);
            this.GamePanel.Location = new System.Drawing.Point(0, 0);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(1707, 886);
            this.GamePanel.TabIndex = 10;
            this.GamePanel.Visible = false;
            // 
            // PlayerSprite
            // 
            this.PlayerSprite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayerSprite.BackgroundImage")));
            this.PlayerSprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerSprite.Location = new System.Drawing.Point(520, 420);
            this.PlayerSprite.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerSprite.Name = "PlayerSprite";
            this.PlayerSprite.Size = new System.Drawing.Size(27, 25);
            this.PlayerSprite.TabIndex = 1;
            this.PlayerSprite.TabStop = false;
            // 
            // BackToMenu
            // 
            this.BackToMenu.Location = new System.Drawing.Point(25, 625);
            this.BackToMenu.Margin = new System.Windows.Forms.Padding(4);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(100, 28);
            this.BackToMenu.TabIndex = 0;
            this.BackToMenu.Text = "BackToMenu";
            this.BackToMenu.UseVisualStyleBackColor = true;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Clicker);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsPanel.BackgroundImage")));
            this.SettingsPanel.Controls.Add(this.BackToMenuFromSettings);
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(1707, 886);
            this.SettingsPanel.TabIndex = 10;
            this.SettingsPanel.Visible = false;
            // 
            // BackToMenuFromSettings
            // 
            this.BackToMenuFromSettings.Location = new System.Drawing.Point(791, 341);
            this.BackToMenuFromSettings.Margin = new System.Windows.Forms.Padding(4);
            this.BackToMenuFromSettings.Name = "BackToMenuFromSettings";
            this.BackToMenuFromSettings.Size = new System.Drawing.Size(100, 28);
            this.BackToMenuFromSettings.TabIndex = 0;
            this.BackToMenuFromSettings.Text = "BackToMenuFromSettings";
            this.BackToMenuFromSettings.UseVisualStyleBackColor = true;
            this.BackToMenuFromSettings.Click += new System.EventHandler(this.BackToMenu_Clicker);
            // 
            // RecordsPanel
            // 
            this.RecordsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RecordsPanel.BackgroundImage")));
            this.RecordsPanel.Controls.Add(this.BackToMenuFromRecords);
            this.RecordsPanel.Location = new System.Drawing.Point(0, 0);
            this.RecordsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.RecordsPanel.Name = "RecordsPanel";
            this.RecordsPanel.Size = new System.Drawing.Size(1707, 886);
            this.RecordsPanel.TabIndex = 10;
            // 
            // BackToMenuFromRecords
            // 
            this.BackToMenuFromRecords.Location = new System.Drawing.Point(828, 363);
            this.BackToMenuFromRecords.Margin = new System.Windows.Forms.Padding(4);
            this.BackToMenuFromRecords.Name = "BackToMenuFromRecords";
            this.BackToMenuFromRecords.Size = new System.Drawing.Size(100, 28);
            this.BackToMenuFromRecords.TabIndex = 0;
            this.BackToMenuFromRecords.Text = "BackToMenuFromRecords";
            this.BackToMenuFromRecords.UseVisualStyleBackColor = true;
            this.BackToMenuFromRecords.Click += new System.EventHandler(this.BackToMenu_Clicker);
            // 
            // TickTimer
            // 
            this.TickTimer.Enabled = true;
            this.TickTimer.Interval = 20;
            this.TickTimer.Tick += new System.EventHandler(this.MovePlayer);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 685);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.RecordsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "App";
            this.Text = "GalagaApp";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSprite)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.RecordsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    
        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RecordsButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label MenuName;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Button BackToMenuFromSettings;
        private System.Windows.Forms.Panel RecordsPanel;
        private System.Windows.Forms.Button BackToMenuFromRecords;
        private System.Windows.Forms.PictureBox PlayerSprite;
        private System.Windows.Forms.Timer TickTimer;
    }
}