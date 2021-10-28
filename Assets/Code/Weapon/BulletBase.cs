using UnityEngine;

namespace Weapon
{
    public abstract class BulletBase:MonoBehaviour
    {
        [SerializeField] protected float _speed;
        [SerializeField] protected float _maxLifeTime;
        [SerializeField] protected float _damage;

        private Transform _parentTransform;
        
        void Start()
        {
            _parentTransform = transform.parent;
        }
        void Update()
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
}