using System.Drawing;

namespace MyFirstGalagaTry {
    public abstract class Enemy {
        protected int hp;
        protected int x, y;
        protected Bitmap enemySprite;

        public Enemy(int _x, int _y) {
            x = _x;
            y = _y;
        }

        public int getX() {
            return x;
        }
        public int getY() {
            return y;
        }

        public Bitmap getSprite() {
            return enemySprite;
        }

        public bool isAlive() {
            return hp > 0;
        }

        public void getDamage() {
            hp -= 50;
        }
    }
}