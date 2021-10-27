using TankClass.Interfaces;
using UnityEngine;

namespace TankClass.Code
{
    public class TankFire : ITankFire
    {
        private Vector2 _spawnPoint;
        private Vector2 _direction;
        public TankFire(Vector2 SpawnPoint, Vector2 direction)
        {
            _spawnPoint = SpawnPoint;
            _direction = direction;

        }

        public void Fire()
        {
            Debug.Log("SCOOTER");
            //Bullet logic
        }
    }
}