using Markers;
using TankUnit.Interfaces;
using UnityEngine;
using Object = UnityEngine.Object;

namespace TankUnit.Code
{
    public class TankView : TankClass, ITankView, ITakeDamage
    {

        public event ITankView.Damaged getNext;
       private Object _bulletExplosionPrefab;
        private Transform _bulletExplosionPosition;
        public bool ai { get; set; }

        private void Awake()
        {
            _bulletExplosionPrefab = Resources.Load("Prefabs/ShellExplosion");
            _bulletExplosionPosition = gameObject.GetComponent<BulletMarker>().transform;
        }

        public float TakeDamage(float damage)
        {
            if (ai) getNext?.Invoke();
            float _damage = damage;
            if (!ai) TankFire.Fire();
            Instantiate(_bulletExplosionPrefab, _bulletExplosionPosition);
            Destroy(GetComponentInChildren<ParticleSystem>().gameObject,2f);
            return damage;
        }
    }
}