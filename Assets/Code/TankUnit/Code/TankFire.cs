using TankUnit.Interfaces;
using UnityEngine;
using Weapon;

namespace TankUnit.Code
{
    public class TankFire : ITankFire
    {
        private Vector3 _spawnPoint;
        private readonly Cannon _cannon;
        public bool Fired { get; set; }
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
            Fired = false;
        }
        public void Fire()
        {
            if (Fired) return;
            _cannon.Shoot();
            Fired = true;
        }
    }
}