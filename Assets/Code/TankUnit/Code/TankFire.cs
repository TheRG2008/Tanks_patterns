using TankUnit.Interfaces;
using UnityEngine;

namespace TankUnit.Code
{
    public class TankFire : ITankFire
    {
        private Vector2 _spawnPoint;
        private Vector2 _direction;
        public TankFire(Vector2 spawnPoint, Vector2 direction)
        {
            _spawnPoint = spawnPoint;
            _direction = direction;

        }

        public void Fire()
        {
            Debug.Log("SCOOTER");
            //Bullet logic
        }
    }
}