using TankUnit.Interfaces;
using UnityEngine;

namespace Weapon
{
    public sealed class BulletStandart:BulletBase
    {
        public void Init()
        {
            Debug.Log("Shell Init");
            Destroy(gameObject, _maxLifeTime);
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Enemy"))
            {
                Debug.Log($"Hit {other.name}");
                other.GetComponent<ITakeDamage>().TakeDamage(_damage);    
            }
            Destroy(gameObject, 2f);
        }
    }
}