using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyFirstGalagaTry {
    public class Game {
        private Player _player;
        private HashSet<Bullet> bulletsOnMap = new HashSet<Bullet>();
        private HashSet<Enemy> enemiesOnMap = new HashSet<Enemy>();
        private bool levelSpawned = false;
        private int curLevelDesign = 0;
        private int levelCount = 5;
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
            enemiesUpdate();
            if (!levelSpawned) {
                spawnEnemies();
            }
            _player.move();
            bulletsUpdate();
        }

        public void EndGame() {
            _player.returnToBegin();
            bulletsOnMap.Clear();
            enemiesOnMap.Clear();
            curLevelDesign = 0;
            levelSpawned = false;
        }

        private void enemiesUpdate() {
            foreach(var bullet in bulletsOnMap){
                foreach (var enemy in enemiesOnMap) {
                    if (bulletAndEnemyCollision(bullet, enemy)) {
                        enemy.getDamage();
                        bullet.setY(-10);
                    }
                }
            }
            enemiesOnMap.RemoveWhere(x => !x.isAlive());
            if (enemiesOnMap.Count == 0)
                levelSpawned = false;
        }
        private void bulletsUpdate() {
            foreach(var bullet in bulletsOnMap){
                bullet.Update();
            }
            bulletsOnMap.RemoveWhere(x => x.getY() < 0);
        }

        public void drawMap(PaintEventArgs paintEventArgs) {
            Graphics graphics = paintEventArgs.Graphics;
            graphics.Clear(Color.Black);
            foreach (var bullet in bulletsOnMap) {
                graphics.DrawImage(bullet.getSprite(),bullet.getX(), bullet.getY());
            }
            foreach (var enemy in enemiesOnMap) {
                graphics.DrawImage(enemy.getSprite(), enemy.getX(), enemy.getY());
            }
        }

        private void spawnEnemies() {
            levelSpawned = true;
            switch (curLevelDesign) {
                case 0: {
                    enemiesOnMap.Add(new BasicEnemy(527, 50));
                    enemiesOnMap.Add(new BasicEnemy(577, 50));
                    enemiesOnMap.Add(new BasicEnemy(627, 50));
                    enemiesOnMap.Add(new BasicEnemy(677, 50));
                } break;
                case 1: {
                    enemiesOnMap.Add(new BasicEnemy(527, 50));
                    enemiesOnMap.Add(new ShootingEnemy(577, 50));
                    enemiesOnMap.Add(new ShootingEnemy(627, 50));
                    enemiesOnMap.Add(new BasicEnemy(677, 50));
                    enemiesOnMap.Add(new BasicEnemy(577, 100));
                    enemiesOnMap.Add(new BasicEnemy(627, 100));
                    enemiesOnMap.Add(new BasicEnemy(602, 150));
                } break;
                case 2: {
                    enemiesOnMap.Add(new ShootingEnemy(527, 50));
                    enemiesOnMap.Add(new ShootingEnemy(577, 50));
                    enemiesOnMap.Add(new ShootingEnemy(627, 50));
                    enemiesOnMap.Add(new ShootingEnemy(677, 50));
                    enemiesOnMap.Add(new BasicEnemy(577, 100));
                    enemiesOnMap.Add(new BasicEnemy(627, 100));
                    enemiesOnMap.Add(new TankEnemy(597, 150));
                    enemiesOnMap.Add(new TankEnemy(527, 100));
                    enemiesOnMap.Add(new TankEnemy(667, 100));
                } break;
                case 3: {
                    enemiesOnMap.Add(new ShootingEnemy(477, 50));
                    enemiesOnMap.Add(new ShootingEnemy(527, 50));
                    enemiesOnMap.Add(new ShootingEnemy(577, 50));
                    enemiesOnMap.Add(new ShootingEnemy(627, 50));
                    enemiesOnMap.Add(new ShootingEnemy(677, 50));
                    enemiesOnMap.Add(new ShootingEnemy(727, 50));
                    enemiesOnMap.Add(new TankEnemy(477, 100));
                    enemiesOnMap.Add(new BasicEnemy(527, 100));
                    enemiesOnMap.Add(new BasicEnemy(577, 100));
                    enemiesOnMap.Add(new BasicEnemy(627, 100));
                    enemiesOnMap.Add(new BasicEnemy(677, 100));
                    enemiesOnMap.Add(new TankEnemy(727, 100));
                    enemiesOnMap.Add(new TankEnemy(517, 150));
                    enemiesOnMap.Add(new TankEnemy(567, 150));
                    enemiesOnMap.Add(new TankEnemy(617, 150));
                    enemiesOnMap.Add(new TankEnemy(667, 150));
                    enemiesOnMap.Add(new TankEnemy(597, 200));
                } break;
                case 4: {
                    enemiesOnMap.Add(new BossEnemy(572, 50));
                } break;
            }
            curLevelDesign = (curLevelDesign + 1) % levelCount;
        }

        private bool bulletAndEnemyCollision(Bullet bullet, Enemy enemy) {
            return (bullet.getSprite().Width / 2 + bullet.getX()) >= enemy.getX() &&
                   (bullet.getSprite().Width / 2 + bullet.getX()) <= (enemy.getX() + enemy.getSprite().Width) &&
                   bullet.getY() <= enemy.getY();
        }
    }
}