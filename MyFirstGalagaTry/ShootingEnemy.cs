using System.Drawing;

namespace MyFirstGalagaTry {
    public class ShootingEnemy : Enemy {
        public ShootingEnemy(int _x, int _y) : base(_x, _y) {
            enemySprite = new Bitmap(new Bitmap("Sprites\\ShootingEnemy.png"), 22, 24);
            hp = 50;
        }
    }
}