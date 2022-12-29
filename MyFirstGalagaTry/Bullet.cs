using System.Drawing;

namespace MyFirstGalagaTry {
    abstract public class Bullet {
        protected Bitmap bulletSprite;
        protected int x, y;
        protected int velocity;
        protected int damage;
        public Bullet(int _x, int _y) {
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
            return bulletSprite;
        }

        public void Update() {
            y += velocity;
        }

        public void setY(int _y) {
            y = _y;
        }

        public int getDamage() {
            return damage;
        }

        public void upgradeBullet(int _v) {
            velocity += _v;
        }
    }
}