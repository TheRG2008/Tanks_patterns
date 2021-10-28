using TankUnit.Interfaces;
using UnityEngine;

namespace TankUnit.Code
{
    public class TankFire : ITankFire
    {
<<<<<<< Updated upstream
        private Vector2 _spawnPoint;
        private Vector2 _direction;
        public TankFire(Vector2 spawnPoint, Vector2 direction)
        {
            _spawnPoint = spawnPoint;
            _direction = direction;

=======
        private Vector3 _spawnPoint;
        private Cannon _cannon;
        public TankFire(Vector3 spawnPoint,  Cannon cannon)
        {
            _spawnPoint = spawnPoint;
            _cannon = cannon;
>>>>>>> Stashed changes
        }

        public bool Fired { get; set; }

        public void Fire()
        {
<<<<<<< Updated upstream
            Debug.Log("SCOOTER");
            //Bullet logic
=======
           if (!Fired) _cannon.Shoot();
           Fired = true;
>>>>>>> Stashed changes
        }
    }
}