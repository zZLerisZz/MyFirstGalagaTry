using System.Drawing;

namespace MyFirstGalagaTry {
    public class EnemyBullet : Bullet {
        public EnemyBullet(int _x, int _y) : base(_x, _y) {
            bulletSprite = new Bitmap(new Bitmap("Sprites\\EnemyBullet.png"), 3, 8);
            velocity = 12;
            damage = 25;
        }
    }
}