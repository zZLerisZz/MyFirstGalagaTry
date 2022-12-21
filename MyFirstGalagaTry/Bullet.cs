using System.Drawing;

namespace MyFirstGalagaTry {
    public class Bullet {
        private Bitmap bulletSprite;
        private int x, y;
        private int velocity = 12;

        public Bullet(int _x, int _y) {
            x = _x;
            y = _y;
            bulletSprite = new Bitmap(new Bitmap("Sprites\\Bullet.png"), 3, 8);
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
            y -= velocity;
        }
    }
}