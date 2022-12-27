using System;
using System.Collections.Generic;

namespace MyFirstGalagaTry {
    public abstract class Enemy : Entity {
        protected uint cost;
        public Enemy(int _x, int _y) {
            x = _x;
            y = _y;
        }
        public uint getCost() {
            return cost;
        }
        public virtual HashSet<Bullet> createAttack() {
            milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            HashSet<Bullet> hashToReturn = new HashSet<Bullet>();
            hashToReturn.Add(new EnemyBullet(x + 8, y + _sprite.Width));
            foreach (var bullet in hashToReturn) {
                bullet.upgradeBullet(upVel);
            }
            return hashToReturn;
        }

        public void update() {
            if (directions[0] && x > 447) {
                x -= velocity;
            }
            else if(directions[1] && x + _sprite.Width < 797) {
                x += velocity;
            }
            else if (x <= 447) {
                directions[0] = false;
                directions[1] = true;
            }
            else if (x + _sprite.Width >= 797) {
                directions[0] = true;
                directions[1] = false;
            }
        }
    }
}