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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.RecordsButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.MenuName = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.RightGameInterFace = new System.Windows.Forms.Panel();
            this.DifficultyData = new System.Windows.Forms.Label();
            this.DifficultyText = new System.Windows.Forms.Label();
            this.UpgradeData = new System.Windows.Forms.Label();
            this.UpgradeText = new System.Windows.Forms.Label();
            this.LevelData = new System.Windows.Forms.Label();
            this.LevelText = new System.Windows.Forms.Label();
            this.PauseStartButton = new System.Windows.Forms.Button();
            this.LeftGameInterFace = new System.Windows.Forms.Panel();
            this.UserName = new System.Windows.Forms.Label();
            this.UserText = new System.Windows.Forms.Label();
            this.HPPanel = new System.Windows.Forms.Panel();
            this.HPText = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.ChangeUserName = new System.Windows.Forms.Button();
            this.UserNameData = new System.Windows.Forms.Label();
            this.UserNameText = new System.Windows.Forms.Label();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.DifficultyGroup = new System.Windows.Forms.GroupBox();
            this.Difficulty0 = new System.Windows.Forms.CheckBox();
            this.Difficulty2 = new System.Windows.Forms.CheckBox();
            this.Difficulty1 = new System.Windows.Forms.CheckBox();
            this.BackToMenuFromSettings = new System.Windows.Forms.Button();
            this.RecordsPanel = new System.Windows.Forms.Panel();
            this.BackToMenuFromRecords = new System.Windows.Forms.Button();
            this.TickTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuPanel.SuspendLayout();
            this.GamePanel.SuspendLayout();
            this.RightGameInterFace.SuspendLayout();
            this.LeftGameInterFace.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.DifficultyGroup.SuspendLayout();
            this.RecordsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuPanel.BackgroundImage")));
            this.MenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuPanel.Controls.Add(this.RecordsButton);
            this.MenuPanel.Controls.Add(this.SettingsButton);
            this.MenuPanel.Controls.Add(this.ExitButton);
            this.MenuPanel.Controls.Add(this.PlayButton);
            this.MenuPanel.Controls.Add(this.MenuName);
            this.MenuPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1280, 960);
            this.MenuPanel.TabIndex = 0;
            // 
            // RecordsButton
            // 
            this.RecordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordsButton.Location = new System.Drawing.Point(481, 497);
            this.RecordsButton.Name = "RecordsButton";
            this.RecordsButton.Size = new System.Drawing.Size(289, 63);
            this.RecordsButton.TabIndex = 8;
            this.RecordsButton.TabStop = false;
            this.RecordsButton.Text = "Рекорды";
            this.RecordsButton.UseVisualStyleBackColor = true;
            this.RecordsButton.Click += new System.EventHandler(this.RecordsButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.Location = new System.Drawing.Point(481, 358);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(289, 63);
            this.SettingsButton.TabIndex = 7;
            this.SettingsButton.TabStop = false;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(481, 634);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(289, 63);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.Location = new System.Drawing.Point(481, 224);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(289, 63);
            this.PlayButton.TabIndex = 6;
            this.PlayButton.TabStop = false;
            this.PlayButton.Text = "Играть";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // MenuName
            // 
            this.MenuName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MenuName.AutoSize = true;
            this.MenuName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuName.Location = new System.Drawing.Point(532, 99);
            this.MenuName.Name = "MenuName";
            this.MenuName.Size = new System.Drawing.Size(179, 55);
            this.MenuName.TabIndex = 5;
            this.MenuName.Text = "МЕНЮ";
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GamePanel.Controls.Add(this.RightGameInterFace);
            this.GamePanel.Controls.Add(this.LeftGameInterFace);
            this.GamePanel.Location = new System.Drawing.Point(0, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(1280, 960);
            this.GamePanel.TabIndex = 10;
            this.GamePanel.Visible = false;
            this.GamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_Paint);
            // 
            // RightGameInterFace
            // 
            this.RightGameInterFace.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RightGameInterFace.Controls.Add(this.DifficultyData);
            this.RightGameInterFace.Controls.Add(this.DifficultyText);
            this.RightGameInterFace.Controls.Add(this.UpgradeData);
            this.RightGameInterFace.Controls.Add(this.UpgradeText);
            this.RightGameInterFace.Controls.Add(this.LevelData);
            this.RightGameInterFace.Controls.Add(this.LevelText);
            this.RightGameInterFace.Controls.Add(this.PauseStartButton);
            this.RightGameInterFace.Location = new System.Drawing.Point(817, 0);
            this.RightGameInterFace.Name = "RightGameInterFace";
            this.RightGameInterFace.Size = new System.Drawing.Size(447, 960);
            this.RightGameInterFace.TabIndex = 4;
            // 
            // DifficultyData
            // 
            this.DifficultyData.AutoSize = true;
            this.DifficultyData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficultyData.Location = new System.Drawing.Point(256, 287);
            this.DifficultyData.Name = "DifficultyData";
            this.DifficultyData.Size = new System.Drawing.Size(0, 31);
            this.DifficultyData.TabIndex = 8;
            // 
            // DifficultyText
            // 
            this.DifficultyText.AutoSize = true;
            this.DifficultyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficultyText.Location = new System.Drawing.Point(23, 285);
            this.DifficultyText.Name = "DifficultyText";
            this.DifficultyText.Size = new System.Drawing.Size(227, 31);
            this.DifficultyText.TabIndex = 7;
            this.DifficultyText.Text = "Сложность игры:";
            // 
            // UpgradeData
            // 
            this.UpgradeData.AutoSize = true;
            this.UpgradeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpgradeData.Location = new System.Drawing.Point(256, 209);
            this.UpgradeData.Name = "UpgradeData";
            this.UpgradeData.Size = new System.Drawing.Size(29, 31);
            this.UpgradeData.TabIndex = 6;
            this.UpgradeData.Text = "0";
            // 
            // UpgradeText
            // 
            this.UpgradeText.AutoSize = true;
            this.UpgradeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpgradeText.Location = new System.Drawing.Point(25, 209);
            this.UpgradeText.Name = "UpgradeText";
            this.UpgradeText.Size = new System.Drawing.Size(225, 31);
            this.UpgradeText.TabIndex = 5;
            this.UpgradeText.Text = "Версия корабля:";
            // 
            // LevelData
            // 
            this.LevelData.AutoSize = true;
            this.LevelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelData.Location = new System.Drawing.Point(224, 145);
            this.LevelData.Name = "LevelData";
            this.LevelData.Size = new System.Drawing.Size(29, 31);
            this.LevelData.TabIndex = 4;
            this.LevelData.Text = "0";
            // 
            // LevelText
            // 
            this.LevelText.AutoSize = true;
            this.LevelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelText.Location = new System.Drawing.Point(25, 145);
            this.LevelText.Name = "LevelText";
            this.LevelText.Size = new System.Drawing.Size(193, 31);
            this.LevelText.TabIndex = 3;
            this.LevelText.Text = "Уровень игры:";
            // 
            // PauseStartButton
            // 
            this.PauseStartButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PauseStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PauseStartButton.Location = new System.Drawing.Point(257, 732);
            this.PauseStartButton.Name = "PauseStartButton";
            this.PauseStartButton.Size = new System.Drawing.Size(145, 92);
            this.PauseStartButton.TabIndex = 2;
            this.PauseStartButton.TabStop = false;
            this.PauseStartButton.Text = "Начать игру";
            this.PauseStartButton.UseVisualStyleBackColor = false;
            this.PauseStartButton.Click += new System.EventHandler(this.PauseStartButton_Click);
            // 
            // LeftGameInterFace
            // 
            this.LeftGameInterFace.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LeftGameInterFace.Controls.Add(this.UserName);
            this.LeftGameInterFace.Controls.Add(this.UserText);
            this.LeftGameInterFace.Controls.Add(this.HPPanel);
            this.LeftGameInterFace.Controls.Add(this.HPText);
            this.LeftGameInterFace.Controls.Add(this.Score);
            this.LeftGameInterFace.Controls.Add(this.PlayerScore);
            this.LeftGameInterFace.Controls.Add(this.BackToMenu);
            this.LeftGameInterFace.Location = new System.Drawing.Point(0, 0);
            this.LeftGameInterFace.Name = "LeftGameInterFace";
            this.LeftGameInterFace.Size = new System.Drawing.Size(447, 960);
            this.LeftGameInterFace.TabIndex = 3;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.Location = new System.Drawing.Point(166, 295);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(91, 31);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "Player";
            // 
            // UserText
            // 
            this.UserText.AutoSize = true;
            this.UserText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserText.Location = new System.Drawing.Point(12, 295);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(148, 31);
            this.UserText.TabIndex = 0;
            this.UserText.Text = "Ваше имя:";
            // 
            // HPPanel
            // 
            this.HPPanel.BackColor = System.Drawing.Color.Red;
            this.HPPanel.Location = new System.Drawing.Point(18, 252);
            this.HPPanel.Name = "HPPanel";
            this.HPPanel.Size = new System.Drawing.Size(100, 20);
            this.HPPanel.TabIndex = 3;
            // 
            // HPText
            // 
            this.HPText.AutoSize = true;
            this.HPText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HPText.Location = new System.Drawing.Point(12, 209);
            this.HPText.Name = "HPText";
            this.HPText.Size = new System.Drawing.Size(217, 31);
            this.HPText.TabIndex = 2;
            this.HPText.Text = "Ваше здоровье:";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score.Location = new System.Drawing.Point(157, 145);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(29, 31);
            this.Score.TabIndex = 1;
            this.Score.Text = "0";
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerScore.Location = new System.Drawing.Point(12, 145);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(139, 31);
            this.PlayerScore.TabIndex = 0;
            this.PlayerScore.Text = "Ваш счет:";
            // 
            // BackToMenu
            // 
            this.BackToMenu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMenu.Location = new System.Drawing.Point(60, 732);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(145, 92);
            this.BackToMenu.TabIndex = 0;
            this.BackToMenu.TabStop = false;
            this.BackToMenu.Text = "Вернуться в меню";
            this.BackToMenu.UseVisualStyleBackColor = false;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Clicker);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsPanel.BackgroundImage")));
            this.SettingsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsPanel.Controls.Add(this.ChangeUserName);
            this.SettingsPanel.Controls.Add(this.UserNameData);
            this.SettingsPanel.Controls.Add(this.UserNameText);
            this.SettingsPanel.Controls.Add(this.UserNameInput);
            this.SettingsPanel.Controls.Add(this.DifficultyGroup);
            this.SettingsPanel.Controls.Add(this.BackToMenuFromSettings);
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(1280, 960);
            this.SettingsPanel.TabIndex = 10;
            this.SettingsPanel.Visible = false;
            // 
            // ChangeUserName
            // 
            this.ChangeUserName.Location = new System.Drawing.Point(677, 525);
            this.ChangeUserName.Name = "ChangeUserName";
            this.ChangeUserName.Size = new System.Drawing.Size(93, 35);
            this.ChangeUserName.TabIndex = 8;
            this.ChangeUserName.Text = "Подтвердить";
            this.ChangeUserName.UseVisualStyleBackColor = true;
            this.ChangeUserName.Click += new System.EventHandler(this.ChangeUserName_Click);
            // 
            // UserNameData
            // 
            this.UserNameData.AutoSize = true;
            this.UserNameData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameData.Location = new System.Drawing.Point(632, 477);
            this.UserNameData.Name = "UserNameData";
            this.UserNameData.Size = new System.Drawing.Size(0, 29);
            this.UserNameData.TabIndex = 7;
            // 
            // UserNameText
            // 
            this.UserNameText.AutoSize = true;
            this.UserNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameText.Location = new System.Drawing.Point(478, 477);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(154, 29);
            this.UserNameText.TabIndex = 6;
            this.UserNameText.Text = "Имя игрока:";
            // 
            // UserNameInput
            // 
            this.UserNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameInput.Location = new System.Drawing.Point(483, 525);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(154, 35);
            this.UserNameInput.TabIndex = 5;
            // 
            // DifficultyGroup
            // 
            this.DifficultyGroup.Controls.Add(this.Difficulty0);
            this.DifficultyGroup.Controls.Add(this.Difficulty2);
            this.DifficultyGroup.Controls.Add(this.Difficulty1);
            this.DifficultyGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficultyGroup.Location = new System.Drawing.Point(483, 209);
            this.DifficultyGroup.Name = "DifficultyGroup";
            this.DifficultyGroup.Size = new System.Drawing.Size(287, 189);
            this.DifficultyGroup.TabIndex = 4;
            this.DifficultyGroup.TabStop = false;
            this.DifficultyGroup.Text = "Текущая сложность";
            // 
            // Difficulty0
            // 
            this.Difficulty0.AutoSize = true;
            this.Difficulty0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Difficulty0.Location = new System.Drawing.Point(6, 37);
            this.Difficulty0.Name = "Difficulty0";
            this.Difficulty0.Size = new System.Drawing.Size(91, 28);
            this.Difficulty0.TabIndex = 1;
            this.Difficulty0.Text = "Улитка";
            this.Difficulty0.UseVisualStyleBackColor = true;
            this.Difficulty0.Click += new System.EventHandler(this.Difficulty0_Click);
            // 
            // Difficulty2
            // 
            this.Difficulty2.AutoSize = true;
            this.Difficulty2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Difficulty2.Location = new System.Drawing.Point(6, 106);
            this.Difficulty2.Name = "Difficulty2";
            this.Difficulty2.Size = new System.Drawing.Size(83, 28);
            this.Difficulty2.TabIndex = 3;
            this.Difficulty2.Text = "Турбо";
            this.Difficulty2.UseVisualStyleBackColor = true;
            this.Difficulty2.Click += new System.EventHandler(this.Difficulty2_Click);
            // 
            // Difficulty1
            // 
            this.Difficulty1.AutoSize = true;
            this.Difficulty1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Difficulty1.Location = new System.Drawing.Point(6, 71);
            this.Difficulty1.Name = "Difficulty1";
            this.Difficulty1.Size = new System.Drawing.Size(74, 28);
            this.Difficulty1.TabIndex = 2;
            this.Difficulty1.Text = "Конь";
            this.Difficulty1.UseVisualStyleBackColor = true;
            this.Difficulty1.Click += new System.EventHandler(this.Difficulty1_Click);
            // 
            // BackToMenuFromSettings
            // 
            this.BackToMenuFromSettings.Location = new System.Drawing.Point(60, 771);
            this.BackToMenuFromSettings.Name = "BackToMenuFromSettings";
            this.BackToMenuFromSettings.Size = new System.Drawing.Size(126, 82);
            this.BackToMenuFromSettings.TabIndex = 0;
            this.BackToMenuFromSettings.Text = "Назад в меню";
            this.BackToMenuFromSettings.UseVisualStyleBackColor = true;
            this.BackToMenuFromSettings.Click += new System.EventHandler(this.BackToMenu_Clicker);
            // 
            // RecordsPanel
            // 
            this.RecordsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RecordsPanel.BackgroundImage")));
            this.RecordsPanel.Controls.Add(this.BackToMenuFromRecords);
            this.RecordsPanel.Location = new System.Drawing.Point(0, 0);
            this.RecordsPanel.Name = "RecordsPanel";
            this.RecordsPanel.Size = new System.Drawing.Size(1280, 960);
            this.RecordsPanel.TabIndex = 10;
            // 
            // BackToMenuFromRecords
            // 
            this.BackToMenuFromRecords.Location = new System.Drawing.Point(621, 295);
            this.BackToMenuFromRecords.Name = "BackToMenuFromRecords";
            this.BackToMenuFromRecords.Size = new System.Drawing.Size(75, 23);
            this.BackToMenuFromRecords.TabIndex = 0;
            this.BackToMenuFromRecords.Text = "BackToMenuFromRecords";
            this.BackToMenuFromRecords.UseVisualStyleBackColor = true;
            this.BackToMenuFromRecords.Click += new System.EventHandler(this.BackToMenu_Clicker);
            // 
            // TickTimer
            // 
            this.TickTimer.Enabled = true;
            this.TickTimer.Interval = 20;
            this.TickTimer.Tick += new System.EventHandler(this.GameUpdate);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.RecordsPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "App";
            this.Text = "GalagaApp";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.GamePanel.ResumeLayout(false);
            this.RightGameInterFace.ResumeLayout(false);
            this.RightGameInterFace.PerformLayout();
            this.LeftGameInterFace.ResumeLayout(false);
            this.LeftGameInterFace.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.DifficultyGroup.ResumeLayout(false);
            this.DifficultyGroup.PerformLayout();
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
        private System.Windows.Forms.Timer TickTimer;
        private System.Windows.Forms.Button PauseStartButton;
        private System.Windows.Forms.Panel LeftGameInterFace;
        private System.Windows.Forms.Panel RightGameInterFace;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Panel HPPanel;
        private System.Windows.Forms.Label HPText;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label UserText;
        private System.Windows.Forms.Label UpgradeData;
        private System.Windows.Forms.Label UpgradeText;
        private System.Windows.Forms.Label LevelData;
        private System.Windows.Forms.Label LevelText;
        private System.Windows.Forms.Label DifficultyData;
        private System.Windows.Forms.Label DifficultyText;
        private System.Windows.Forms.GroupBox DifficultyGroup;
        private System.Windows.Forms.CheckBox Difficulty0;
        private System.Windows.Forms.CheckBox Difficulty2;
        private System.Windows.Forms.CheckBox Difficulty1;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.Label UserNameData;
        private System.Windows.Forms.Label UserNameText;
        private System.Windows.Forms.Button ChangeUserName;
    }
}