using System;
using System.Windows.Forms;

namespace MyFirstGalagaTry
{
  
    public partial class App : Form
    {
        private Game gameApp;
        private WMPLib.WindowsMediaPlayer musicPlayer;
        private RecordsTable _recordsTable;
        public App() {
            InitializeComponent();
            gameApp = new Game();
            TickTimer.Stop();
            musicPlayer = new WMPLib.WindowsMediaPlayer();
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty).SetValue(GamePanel, true, null);
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty).SetValue(MenuPanel, true, null);
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty).SetValue(SettingsPanel, true, null);
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty).SetValue(RecordsPanel, true, null);
            musicPlayer.URL = "Other\\Background.wav";
            musicPlayer.settings.volume = 20;
            MusicVolumeChange.Value = 20;
            MusicLoudData.Text = MusicVolumeChange.Value.ToString();
            musicPlayer.settings.setMode("loop", true);
            musicPlayer.settings.autoStart = true;
            _recordsTable = new RecordsTable();
            _recordsTable.ReadRecordsTable();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            switch (keyData) {
                    case Keys.Left: {
                        if (GamePanel.Visible && TickTimer.Enabled) {
                            gameApp.playerMoveLeft();
                        }
                    } break;
                    case Keys.Right: {
                        if (GamePanel.Visible && TickTimer.Enabled) {
                            gameApp.playerMoveRight();
                        }
                    } break;
                    case Keys.Down: {
                        if (GamePanel.Visible && TickTimer.Enabled) {
                            gameApp.playerStop();
                        }
                    }
                    break;
                    case Keys.Up: break;
                    default: return base.ProcessCmdKey(ref msg, keyData);
                }
            return true;
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void PlayButton_Click(object sender, EventArgs e) {
            MenuPanel.Visible = false;
            GamePanel.Visible = true;
            switch (gameApp.getDifiiculty()) {
                case 0: {
                    DifficultyData.Text = "Улитка";
                } break;
                case 1: {
                    DifficultyData.Text = "Конь";
                } break;
                case 2: {
                    DifficultyData.Text = "Турбо";
                } break;
            }
            UserName.Text = gameApp.getUserName();
        }
        private void SettingsButton_Click(object sender, EventArgs e) {
            MenuPanel.Visible = false;
            SettingsPanel.Visible = true;
            UserNameData.Text = gameApp.getUserName();
            switch (gameApp.getDifiiculty()) {
                case 0: {
                    Difficulty0.Checked = true;
                    Difficulty1.Checked = false;
                    Difficulty2.Checked = false;
                } break;
                case 1: {
                    Difficulty0.Checked = false;
                    Difficulty1.Checked = true;
                    Difficulty2.Checked = false;
                } break;
                case 2: {
                    Difficulty0.Checked = false;
                    Difficulty1.Checked = false;
                    Difficulty2.Checked = true;
                } break;
            }
            SettingsPanel.Focus();
        }

        private void BackToMenu_Clicker(object sender, EventArgs e) {
            if (GamePanel.Visible) {
                TickTimer.Stop();
                PauseStartButton.Text = "Начать игру";
                gameApp.EndGame();
                Score.Text = gameApp.getScore().ToString();
                LevelData.Text = gameApp.getLevel().ToString();
                UpgradeData.Text = gameApp.getUpgrade().ToString();
            }
            if (SettingsPanel.Visible) {
                if (UserNameInput.Text != "") {
                    gameApp.setUserName(UserNameInput.Text);
                    UserNameInput.Text = "";
                    UserNameData.Text = gameApp.getUserName();
                }
            }
            MenuPanel.Visible = true;
            RecordsPanel.Visible = false;
            SettingsPanel.Visible = false;
            GamePanel.Visible = false;
            MenuPanel.Focus();
        }

        private void RecordsButton_Click(object sender, EventArgs e) {
            MenuPanel.Visible = false;
            RecordsPanel.Visible = true;
            RecordsPanel.Focus();
            Record1Data.Text = _recordsTable.getSinglePlayer(0);
            Record2Data.Text = _recordsTable.getSinglePlayer(1);
            Record3Data.Text = _recordsTable.getSinglePlayer(2);
            Record4Data.Text = _recordsTable.getSinglePlayer(3);
            Record5Data.Text = _recordsTable.getSinglePlayer(4);
            Record6Data.Text = _recordsTable.getSinglePlayer(5);
            Record7Data.Text = _recordsTable.getSinglePlayer(6);
            Record8Data.Text = _recordsTable.getSinglePlayer(7);
            Record9Data.Text = _recordsTable.getSinglePlayer(8);
            Record10Data.Text = _recordsTable.getSinglePlayer(9);
        }

        private void GameUpdate(object sender, EventArgs e) {
            if (GamePanel.Visible && gameApp.isGoing()) {
                gameApp.playerAttack();
                gameApp.Update();
                GamePanel.Invalidate();
                Score.Text = gameApp.getScore().ToString();
                LevelData.Text = gameApp.getLevel().ToString();
                UpgradeData.Text = gameApp.getUpgrade().ToString();
                HPPanel.Width = gameApp.getPlayerHP();
            }
            else if(!gameApp.isGoing()) {
                _recordsTable.ChangeRecordsTable(gameApp.getUserName(), gameApp.getScore());
                _recordsTable.WriteRecordsTable();
                TickTimer.Stop();
                PauseStartButton.Text = "Начать игру";
            }
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e) {
            gameApp.drawMap(e);
        }

        private void PauseStartButton_Click(object sender, EventArgs e) {
            if (!TickTimer.Enabled) {
                TickTimer.Start();
                PauseStartButton.Text = "Пауза";
            }
            else {
                TickTimer.Stop();
                PauseStartButton.Text = "Продолжить";
            }
            GamePanel.Focus();
        }

        private void Difficulty0_Click(object sender, EventArgs e) {
            Difficulty0.Checked = true;
            Difficulty1.Checked = false;
            Difficulty2.Checked = false;
            gameApp.setDifficulty(0);
        }

        private void Difficulty1_Click(object sender, EventArgs e) {
            Difficulty0.Checked = false;
            Difficulty1.Checked = true;
            Difficulty2.Checked = false;
            gameApp.setDifficulty(1);
        }

        private void Difficulty2_Click(object sender, EventArgs e) {
            Difficulty0.Checked = false;
            Difficulty1.Checked = false;
            Difficulty2.Checked = true;
            gameApp.setDifficulty(2);
        }

        private void ChangeUserName_Click(object sender, EventArgs e) {
            SettingsPanel.Focus();
            if (UserNameInput.Text != "") {
                gameApp.setUserName(UserNameInput.Text);
                UserNameInput.Text = "";
                UserNameData.Text = gameApp.getUserName();
            }
        }

        private void MusicVolumeChange_Scroll(object sender, EventArgs e) {
            musicPlayer.settings.volume = MusicVolumeChange.Value;
            MusicLoudData.Text = MusicVolumeChange.Value.ToString();
        }
    }
}