using System.Drawing;

namespace MyFirstGalagaTry {
    public class ShootingEnemy : Enemy {
        public ShootingEnemy(int _x, int _y) : base(_x, _y) {
            _sprite = new Bitmap(new Bitmap("Sprites\\ShootingEnemy.png"), 22, 24);
            hp = 50;
            cost = 200;
            coolDown = 3000;
            velocity = 6;
            directions[0] = true;
            upVel = 2;
        }
    }
}