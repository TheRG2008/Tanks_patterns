using TankUnit.Interfaces;
using UnityEngine;
using Weapon;

namespace TankUnit.Code
{
    public class TankFire : ITankFire
    {
        private Vector2 _spawnPoint;
        private Vector2 _direction;
        private Cannon _cannon;
        public TankFire(Vector2 spawnPoint, Vector2 direction, Cannon cannon)
        {
            _spawnPoint = spawnPoint;
            _direction = direction;
            _cannon = cannon;
        }

        public void Fire()
        {
            _cannon.Shoot();
            Debug.Log("SCOOTER");
            //Bullet logic
        }
    }
}