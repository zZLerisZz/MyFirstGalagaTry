using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace MyFirstGalagaTry
{
  
    public partial class App : Form
    {
        private Game gameApp;
        public App() {
            InitializeComponent();
            gameApp = new Game();
            TickTimer.Stop();
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty).SetValue(GamePanel, true, null);
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty).SetValue(MenuPanel, true, null);
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty).SetValue(SettingsPanel, true, null);
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty).SetValue(RecordsPanel, true, null);
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
                    // case Keys.Space: {
                    //     if (GamePanel.Visible) {
                    //         gameApp.playerAttack();
                    //     }
                    // } break;
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
            MenuPanel.Focus();
            if (GamePanel.Visible) {
                TickTimer.Stop();
                PauseStartButton.Text = "Начать игру";
                gameApp.EndGame();
                Score.Text = gameApp.getScore().ToString();
                LevelData.Text = gameApp.getLevel().ToString();
                UpgradeData.Text = gameApp.getUpgrade().ToString();
            }
            if (RecordsPanel.Visible) {
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
        }

        private void RecordsButton_Click(object sender, EventArgs e) {
            MenuPanel.Visible = false;
            RecordsPanel.Visible = true;
            RecordsPanel.Focus();
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
    }
}