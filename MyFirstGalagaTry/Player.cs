using System;
using System.Windows.Forms;

namespace MyFirstGalagaTry
{
    public class Player {
        private PictureBox playerSprite;
        private int hp = 100;
        private int velocity = 12;
        private bool[] directions;
        private int[] startPosition;
        public Player(PictureBox sprite) {
            playerSprite = sprite;
            directions = new bool[2];
            directions[0] = directions[1] = false;
            startPosition = new int[2] { playerSprite.Left, playerSprite.Top };
        }

        public void setLeftDirection() {
            directions[0] = true;
            directions[1] = false;
        }

        public void setRightDirection() {
            directions[0] = false;
            directions[1] = true;
        }

        public void setStop() {
            directions[0] = directions[1] = false;
        }

        public void move() {
            if (directions[0]) {
                playerSprite.Left -= velocity;
            }
            if(directions[1]) {
                playerSprite.Left += velocity;
            }
        }

        public void returnToBegin()
        {
            playerSprite.Left = startPosition[0];
            playerSprite.Top = startPosition[1];
        }
        
    }
}