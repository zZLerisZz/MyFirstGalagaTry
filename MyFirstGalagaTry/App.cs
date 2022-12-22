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
            gameApp = new Game(new Player(PlayerSprite));
            TickTimer.Stop();
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty).SetValue(GamePanel, true, null);
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty).SetValue(MenuPanel, true, null);
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
        }

        private void SettingsButton_Click(object sender, EventArgs e) {
            MenuPanel.Visible = false;
            SettingsPanel.Visible = true;
        }

        private void BackToMenu_Clicker(object sender, EventArgs e) {
            MenuPanel.Visible = true;
            RecordsPanel.Visible = false;
            SettingsPanel.Visible = false;
            if (GamePanel.Visible) {
                TickTimer.Stop();
                PauseStartButton.Text = "Start";
                gameApp.EndGame();
            }

            GamePanel.Visible = false;
        }

        private void RecordsButton_Click(object sender, EventArgs e) {
            MenuPanel.Visible = false;
            RecordsPanel.Visible = true;
            
        }

        private void GameUpdate(object sender, EventArgs e) {
            if (GamePanel.Visible) {
                gameApp.playerAttack();
                gameApp.Update();
            }
            GamePanel.Invalidate();
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e) {
            gameApp.drawMap(e);
        }

        private void PauseStartButton_Click(object sender, EventArgs e) {
            if (!TickTimer.Enabled) {
                TickTimer.Start();
                PauseStartButton.Text = "Stop";
            }
            else {
                TickTimer.Stop();
                PauseStartButton.Text = "Start";
            }
            PauseStartButton.Parent.Focus();
        }
    }
}