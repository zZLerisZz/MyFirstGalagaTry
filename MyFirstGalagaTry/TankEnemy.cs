using System.Drawing;

namespace MyFirstGalagaTry {
    public class TankEnemy : Enemy {
        public TankEnemy(int _x, int _y) : base(_x, _y) {
            enemySprite = new Bitmap(new Bitmap("Sprites\\TankEnemy.png"), 34, 30);
            hp = 200;
        }
    }
}