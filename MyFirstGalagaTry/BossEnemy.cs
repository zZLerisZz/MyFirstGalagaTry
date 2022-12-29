using System;
using System.Collections.Generic;
using System.Drawing;

namespace MyFirstGalagaTry {
    public class BossEnemy : Enemy {
        public BossEnemy(int _x, int _y) : base(_x, _y) {
            _sprite = new Bitmap(new Bitmap("Sprites\\BossEnemy.png"), 80, 106);
            hp = 2000;
            cost = 10000;
            coolDown = 500;
            velocity = 6;
            directions[1] = true;
            upVel = 3;
        }

        public override HashSet<Bullet> createAttack() {
            milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            HashSet<Bullet> hashToReturn = new HashSet<Bullet>();
            hashToReturn.Add(new EnemyBullet(x + 7, y + _sprite.Width));
            hashToReturn.Add(new EnemyBullet(x + 35, y + _sprite.Width));
            hashToReturn.Add(new EnemyBullet(x + 63, y + _sprite.Width));
            foreach (var bullet in hashToReturn) {
                bullet.upgradeBullet(upVel);
            }
            return hashToReturn;
        }
        
    }
}