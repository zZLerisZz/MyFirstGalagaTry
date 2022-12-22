using System.Drawing;

namespace MyFirstGalagaTry {
    public class BossEnemy : Enemy {
        public BossEnemy(int _x, int _y) : base(_x, _y) {
            enemySprite = new Bitmap(new Bitmap("Sprites\\BossEnemy.png"), 80, 106);
            hp = 500;
        }
    }
}