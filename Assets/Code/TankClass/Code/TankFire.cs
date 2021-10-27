using TankClass.Interfaces;
using UnityEngine;

namespace TankClass.Code
{
    public class TankFire : ITankFire
    {
        private Vector2 _spawnPoint;
        public TankFire(Vector2 SpawnPoint)
        {
            _spawnPoint = SpawnPoint;
            Fire();
        }

        public void Fire()
        {
            Debug.Log("SCOOTER");
            //Bullet logic
        }
    }
}