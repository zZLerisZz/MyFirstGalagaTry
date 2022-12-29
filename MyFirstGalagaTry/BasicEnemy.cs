using System.Drawing;

namespace MyFirstGalagaTry {
    public class BasicEnemy : Enemy {
        public BasicEnemy(int _x, int _y) : base(_x, _y) {
            _sprite = new Bitmap(new Bitmap("Sprites\\BasicEnemy.png"), 18, 22);
            hp = 100;
            cost = 100;
            coolDown = 6000;
            velocity = 4;
            directions[0] = true;
            upVel = 1;
        }
    }
}