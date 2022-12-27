using System.Drawing;

namespace MyFirstGalagaTry {
    public class PlayerBullet : Bullet {
        public PlayerBullet(int _x, int _y) : base(_x, _y) {
            bulletSprite = new Bitmap(new Bitmap("Sprites\\PlayerBullet.png"), 3, 8);
            velocity = -12;
            damage = 50;
        }
    }
}