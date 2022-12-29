using System;
using System.Collections.Generic;
using System.Drawing;

namespace MyFirstGalagaTry
{
    public class Player : Entity {
        private int[] startPosition = { 612, 788 };
        private int curlevel = 0;
        private int bossCounter = 0;
        public Player() {
            _sprite = new Bitmap(new Bitmap("Sprites\\PlayerSprite0.png"), 20, 20);
            directions = new bool[2];
            x = 612;
            y = 788;
            coolDown = 75;
            hp = 100;
            velocity = 12;
            upVel = 0;
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
            if (directions[0] && x > 447) {
                x -= velocity;
            }
            else if(directions[1] && x + _sprite.Width - 16 < 797) {
                x += velocity;
            }
            else if(x <= 447) {
                directions[0] = false;
                milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            }
            else if(x + _sprite.Width - 16 >= 797){
                directions[1] = false;
                milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            }
        }

        public void returnToBegin() {
            x = startPosition[0];
            y = startPosition[1];
            _sprite = new Bitmap(new Bitmap("Sprites\\PlayerSprite0.png"), 20, 20);
            directions[0] = directions[1] = false;
            curlevel = 0;
            hp = 100;
            bossCounter = 0;
            upVel = 0;
            coolDown = 75;
            velocity = 12;
        }

        public void bossesKilled() {
            bossCounter += 1;
            if(bossCounter == 4 || bossCounter == 10)
                upgrade();
        }
        private void upgrade() {
            curlevel += 1;
            hp += 100;
            velocity += 6;
            upVel += 3;
            _sprite = new Bitmap(new Bitmap("Sprites\\PlayerSprite" + curlevel + ".png"), 20, 20);
        }
        
        public override HashSet<Bullet> createAttack() {
            milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            HashSet<Bullet> hashToReturn = new HashSet<Bullet>();
            switch (curlevel) {
                case 0: {
                    hashToReturn.Add(new PlayerBullet(x + 7, y));
                } break;
                case 1: {
                    hashToReturn.Add(new PlayerBullet(x, y));
                    hashToReturn.Add(new PlayerBullet(x + 14, y));
                } break;
                case 2: {
                    hashToReturn.Add(new PlayerBullet(x, y));
                    hashToReturn.Add(new PlayerBullet(x + 7, y));
                    hashToReturn.Add(new PlayerBullet(x + 14, y));
                } break;
            }
            foreach (var bullet in hashToReturn) {
                bullet.upgradeBullet(upVel);
            }
            return hashToReturn;
        }

        public int getBossCounte() {
            return bossCounter;
        }

        public int getCurLevel() {
            return curlevel;
        }

        public override void updateVelocity(int mod, int lvl) {
            if (coolDown > 25)
                coolDown--;
        }
    }
}