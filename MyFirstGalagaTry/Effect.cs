using System.Drawing;

namespace MyFirstGalagaTry {
    public class Effect {
        private Bitmap effectSprite;
        private int x, y;
        private int frames = 6;
        public Effect(int _x, int _y, int _width, int _height) {
            x = _x;
            y = _y;
            effectSprite = new Bitmap(new Bitmap("Sprites\\Explosion.png"), _width, _height);
        }

        public void Update() {
            frames -= 1;
        }

        public bool isDrawable() {
            return frames > 0;
        }

        public int getX() {
            return x;
        }
        public int getY() {
            return y;
        }
        public Bitmap getSprite() {
            return effectSprite;
        }
    }
}