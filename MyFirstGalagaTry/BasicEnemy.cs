using System.Drawing;

namespace MyFirstGalagaTry {
    public class BasicEnemy : Enemy {
        public BasicEnemy(int _x, int _y) : base(_x, _y) {
            enemySprite = new Bitmap(new Bitmap("Sprites\\BasicEnemy.png"), 18, 22);
            hp = 100;
        }
    }
}