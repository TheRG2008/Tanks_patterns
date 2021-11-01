using TankUnit.Interfaces;
using UnityEngine;
using Weapon;

namespace TankUnit.Code
{
    public class TankFire : ITankFire
    {
        private Vector3 _spawnPoint;
        private readonly Cannon _cannon;
        private bool _fired;
        public bool Fired
        {
            get => _fired;
            set => _fired = value;
        }

        public event ITankFire.MoveToNext MoveIt;
        public TankFire(Vector3 spawnPoint, Cannon cannon, ITankView tankView)
        {
            _spawnPoint = spawnPoint;
            _cannon = cannon;
            tankView.GETNext += () =>
            {
                MoveIt?.Invoke();
                Fire();
            };
            _fired = false;
        }
        public void Fire()
        {
            if (_fired)
            {
                Debug.Log("no ammo");
          //      MoveIt?.Invoke();
                return;
            }
            _cannon.Shoot();
            _fired = true;
        }
    }
}