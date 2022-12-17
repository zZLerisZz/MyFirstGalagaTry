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
        private int speed = 12;
        private bool[] move = { false, false };
        public App()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

                 switch (keyData)
                {
                    case Keys.Left: {
                        if (GamePanel.Visible)
                        {
                            move[1] = false;
                            move[0] = true;
                        }
                    } break;
                    case Keys.Right: {
                        if (GamePanel.Visible)
                        {
                            move[1] = true;
                            move[0] = false;
                        }
                    } break;
                    case Keys.Down:
                    {
                        if (GamePanel.Visible)
                        {
                            move[1] = move[0] = false;
                        }
                    }
                    break;
                    case Keys.Up: break;
                    default: return base.ProcessCmdKey(ref msg, keyData);
                }
            return true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = false;
            GamePanel.Visible = true;
            TickTimer.Start();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = false;
            SettingsPanel.Visible = true;
        }

        private void BackToMenu_Clicker(object sender, EventArgs e)
        {
            MenuPanel.Visible = true;
            RecordsPanel.Visible = false;
            SettingsPanel.Visible = false;
            GamePanel.Visible = false;
        }

        private void RecordsButton_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = false;
            RecordsPanel.Visible = true;
            
        }

        private void MovePlayer(object sender, EventArgs e)
        {
            if (move[0])
            {
                Player.Left -= speed;
                //move[0] = false;
            }
            if (move[1])
            {
                Player.Left += speed;
                //move[1] = false;
            }
        }
    }
}