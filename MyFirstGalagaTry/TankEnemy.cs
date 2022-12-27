using System.Drawing;

namespace MyFirstGalagaTry {
    public class TankEnemy : Enemy {
        public TankEnemy(int _x, int _y) : base(_x, _y) {
            _sprite = new Bitmap(new Bitmap("Sprites\\TankEnemy.png"), 34, 30);
            hp = 200;
            cost = 300;
            coolDown = 12000;
            velocity = 2;
            directions[1] = true;
        }
    }
}