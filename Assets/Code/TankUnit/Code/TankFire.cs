using TankUnit.Interfaces;
using UnityEngine;
using Weapon;

namespace TankUnit.Code
{
    public class TankFire : ITankFire
    {

        private Vector3 _spawnPoint;
        private Cannon _cannon;
        public TankFire(Vector3 spawnPoint,  Cannon cannon)
        {
            _spawnPoint = spawnPoint;
            _cannon = cannon;

        }

        public bool Fired { get; set; }

        public void Fire()
        {
            if (!Fired)
            {
                _cannon.Shoot();
                Fired = true;
            }
        }
    }
}