using System;
using Markers;
using TankUnit.Interfaces;
using UnityEngine;
using Object = UnityEngine.Object;

namespace TankUnit.Code
{
    public class TankView : TankClass, ITankView, ITakeDamage
    {
        private Object _shellExplosionPrefab;
        private Transform _shellExplosionPosition;
        public bool ai { get; set; }

        private void Awake()
        {
            _shellExplosionPrefab = Resources.Load("Prefabs/ShellExplosion");
            _shellExplosionPosition = gameObject.GetComponent<BulletMarker>().transform;
        }

        public float TakeDamage(float damage)
        {
            
            float _damage = damage;
            if (!ai) TankFire.Fire();
            //if (!gameObject.TryGetComponent(out _shellExplosionPrefab))
            //{
            //    Debug.Log("TryGetComponent");
            //}
            Instantiate(_shellExplosionPrefab, _shellExplosionPosition);
            //Destroy();
            return damage;
        }
    }
}