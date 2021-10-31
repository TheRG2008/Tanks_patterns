using TankUnit.Code;
using TankUnit.Interfaces;
using UnityEngine;

namespace Weapon
{
    public sealed class BulletStandart : BulletBase
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<TankView>(out var val))
           {
               Debug.Log($"Hit {other.name}");
               other.GetComponent<ITakeDamage>().TakeDamage(damage);    
               Instantiate(bulletExplosionPrefab, bulletExplosionPosition);
               Destroy(gameObject,0.5f);
           }
        }
    }
}