using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstGalagaTry
{
  
    public partial class App : Form
    {
        private Player _player;
        public App() {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {

                 switch (keyData) {
                    case Keys.Left: {
                        if (GamePanel.Visible) {
                            _player.setLeftDirection();
                        }
                    } break;
                    case Keys.Right: {
                        if (GamePanel.Visible) {
                            _player.setRightDirection();
                        }
                    } break;
                    case Keys.Down: {
                        if (GamePanel.Visible) {
                            _player.setStop();
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
            _player = new Player(PlayerSprite);
        }

        private void SettingsButton_Click(object sender, EventArgs e) {
            MenuPanel.Visible = false;
            SettingsPanel.Visible = true;
        }

        private void BackToMenu_Clicker(object sender, EventArgs e) {
            MenuPanel.Visible = true;
            RecordsPanel.Visible = false;
            SettingsPanel.Visible = false;
            if(GamePanel.Visible)
                _player.Dispose();
            GamePanel.Visible = false;
        }

        private void RecordsButton_Click(object sender, EventArgs e) {
            MenuPanel.Visible = false;
            RecordsPanel.Visible = true;
            
        }

        private void MovePlayer(object sender, EventArgs e) {
            if(GamePanel.Visible)
                _player.move();
        }
    }
}