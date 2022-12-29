using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;

namespace MyFirstGalagaTry {
    abstract public class Entity {
        protected int hp;
        protected int x, y;
        protected Bitmap _sprite;
        protected int coolDown;
        protected long milliseconds = 0;
        protected int velocity;
        protected bool[] directions = {false, false};
        protected int upVel;
        public bool isAlive() {
            return hp > 0;
        }

        public void getDamage(int dmg) {
            hp -= dmg;
        }
        public int getX() {
            return x;
        }
        public int getY() {
            return y;
        }
        public Bitmap getSprite() {
            return _sprite;
        }

        public int getHP() {
            return hp;
        }
        public bool canAttack() {
            return DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond - milliseconds >= coolDown;
        }

        public virtual HashSet<Bullet> createAttack() {
            return null;
        }

        public virtual void updateVelocity(int mod, int lvl) {
            switch (mod) {
                case 0: {
                    velocity *= (int)Math.Sqrt(lvl) + 1;
                    if (coolDown > 75) {
                        coolDown /= (int)Math.Sqrt(lvl) + 1;
                    }
                } break;
                case 1: {
                    velocity *= lvl + 1;
                    if (coolDown > 75) {
                        coolDown /= lvl + 1;
                    }
                } break;
                case 2: {
                    velocity *= (int)Math.Exp(lvl) + 1;
                    if (coolDown > 75) {
                        coolDown /= (int)Math.Exp(lvl) + 1;
                    }
                } break;
            }
        }
    }
}