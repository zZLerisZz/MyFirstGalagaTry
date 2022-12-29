using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyFirstGalagaTry {
    public class Game {
        private Player _player;
        private HashSet<HashSet<Bullet>> bulletsOfPlayerOnMap = new HashSet<HashSet<Bullet>>();
        private HashSet<HashSet<Bullet>> bulletsOfEnemiesOnMap = new HashSet<HashSet<Bullet>>();
        private HashSet<Enemy> enemiesOnMap = new HashSet<Enemy>();
        private HashSet<Effect> effectsOnMap = new HashSet<Effect>();
        private bool levelSpawned = false;
        private int curLevelDesign = 0;
        private int levelCount = 5;
        private uint playerScore = 0;
        private int difficulty = 0;
        private String userName = "Player";
        
        public Game() {
            _player = new Player();
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
                bulletsOfPlayerOnMap.Add(_player.createAttack());
        }
        public void Update() {
            enemiesUpdate();
            effectsUpdate();
            if (!levelSpawned) {
                spawnEnemies();
            }
            _player.move();
            bulletsUpdate();
            if (!_player.isAlive()) {
                MessageBox.Show("Вы проиграли!\nВаш счет: " + playerScore);
                EndGame();
            }
        }

        public void EndGame() {
            _player.returnToBegin();
            bulletsOfPlayerOnMap.Clear();
            bulletsOfEnemiesOnMap.Clear();
            enemiesOnMap.Clear();
            effectsOnMap.Clear();
            curLevelDesign = 0;
            levelSpawned = false;
            playerScore = 0;
            GC.Collect();
        }

        public void effectsUpdate() {
            foreach (var effect in effectsOnMap) {
                effect.Update();
            }
            effectsOnMap.RemoveWhere(x => !x.isDrawable());
        }
        private void enemiesUpdate() {
            foreach (var enemy in enemiesOnMap){
                foreach(var bullets in bulletsOfPlayerOnMap) {
                    foreach (var bullet in bullets) {
                        if (bulletAndEntityCollision(bullet, enemy)) {
                            enemy.getDamage(bullet.getDamage());
                            effectsOnMap.Add(new Effect(enemy.getX(), enemy.getY(), enemy.getSprite().Width, enemy.getSprite().Height));
                            bullet.setY(-10);
                        }
                    }
                }
                enemy.update();
                if (!enemy.isAlive()) {
                    playerScore += (uint)(2 * difficulty + 1) * enemy.getCost();
                }
                if (enemy.canAttack())
                    bulletsOfEnemiesOnMap.Add(enemy.createAttack());
            }
            enemiesOnMap.RemoveWhere(x => !x.isAlive());
            if (enemiesOnMap.Count == 0)
                levelSpawned = false;
        }
        private void bulletsUpdate() {
            foreach(var bullets in bulletsOfPlayerOnMap){
                foreach (var bullet in bullets) {
                    bullet.Update();
                }
                bullets.RemoveWhere(x => x.getY() < 0);
            }
            bulletsOfPlayerOnMap.RemoveWhere(x => x.Count == 0);
            foreach(var bullets in bulletsOfEnemiesOnMap){
                foreach (var bullet in bullets) {
                    bullet.Update();
                    if (bulletAndEntityCollision(bullet, _player)) {
                        _player.getDamage(bullet.getDamage());
                        effectsOnMap.Add(new Effect(_player.getX(), _player.getY(), _player.getSprite().Width, _player.getSprite().Height));
                        bullet.setY(-10);
                    }
                }
                bullets.RemoveWhere(x => x.getY() > 960);
            }
            bulletsOfPlayerOnMap.RemoveWhere(x => x.Count == 0);
        }

        public void drawMap(PaintEventArgs paintEventArgs) {
            Graphics graphics = paintEventArgs.Graphics;
            graphics.Clear(Color.Black);
            foreach (var bullets in bulletsOfPlayerOnMap) {
                foreach (var bullet in bullets) {
                    graphics.DrawImage(bullet.getSprite(),bullet.getX(), bullet.getY());
                }
            }
            foreach (var bullets in bulletsOfEnemiesOnMap) {
                foreach (var bullet in bullets) {
                    graphics.DrawImage(bullet.getSprite(),bullet.getX(), bullet.getY());
                }
            }
            foreach (var enemy in enemiesOnMap) {
                graphics.DrawImage(enemy.getSprite(), enemy.getX(), enemy.getY());
            }
            graphics.DrawImage(_player.getSprite(), _player.getX(), _player.getY());
            foreach (var effect in effectsOnMap) {
                graphics.DrawImage(effect.getSprite(), effect.getX(), effect.getY());
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
                    _player.bossesKilled();
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
                    GC.Collect();
                } break;
            }
            curLevelDesign = (curLevelDesign + 1) % levelCount;
            foreach (var enemy in enemiesOnMap) {
                enemy.updateVelocity(difficulty, _player.getCurLevel());
            }
            _player.updateVelocity(difficulty, _player.getCurLevel());
        }

        public uint getScore() {
            return playerScore;
        }
        private bool bulletAndEntityCollision(Bullet bullet, Entity entity) {
            return (bullet.getSprite().Width / 2 + bullet.getX()) >= entity.getX() &&
                   (bullet.getSprite().Width / 2 + bullet.getX()) <= (entity.getX() + entity.getSprite().Width) &&
                   ((bullet.getY() <= entity.getY() + entity.getSprite().Height && bullet.getY() > entity.getY()) ||
                    (bullet.getY() + bullet.getSprite().Height <= entity.getY() && bullet.getY() + bullet.getSprite().Height > entity.getY() + entity.getSprite().Height));
        }

        public int getPlayerHP() {
            return _player.getHP();
        }

        public int getLevel() {
            return _player.getBossCounte();
        }

        public int getUpgrade() {
            return _player.getCurLevel();
        }

        public bool isGoing() {
            return _player.isAlive();
        }

        public int getDifiiculty() {
            return difficulty;
        }

        public String getUserName() {
            return userName;
        }

        public void setDifficulty(int dif) {
            difficulty = dif;
        }

        public void setUserName(String login) {
            userName = login;
        }
    }
}