using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyFirstGalagaTry {
    public class Game {
        private Player _player;
        private HashSet<Bullet> bulletsOnMap = new HashSet<Bullet>();
        public Game(Player setPlayer) {
            _player = setPlayer;
        }

        public void playerMoveLeft() {
            _player.setLeftDirection();
        }
        public void playerMoveRight() {
            _player.setRightDirection();
        }
        public void playerStop() {
            _player.setStop();
        }

        public void playerAttack() {
            if(_player.canAttack())
                bulletsOnMap.Add(_player.createAttack());
        }
        public void Update() {
            _player.move();
            bulletsUpdate();
        }

        public void EndGame() {
            _player.returnToBegin();
            bulletsOnMap.Clear();
        }

        private void bulletsUpdate() {
            foreach(var bullet in bulletsOnMap){
                bullet.Update();
            }
            bulletsOnMap.RemoveWhere(x => x.getY() < 0);
        }

        public void drawBullets(PaintEventArgs paintEventArgs) {
            Graphics graphics = paintEventArgs.Graphics;
            graphics.Clear(Color.Black);
            foreach (var bullet in bulletsOnMap) {
                graphics.DrawImage(bullet.getSprite(),bullet.getX(), bullet.getY());
            }
        }
    }
}