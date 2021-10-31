using UnityEngine;
using UnityEngine.Serialization;

namespace Weapon
{
    public abstract class BulletBase:MonoBehaviour
    {
        [FormerlySerializedAs("_speed")] [SerializeField] protected float speed;
        [FormerlySerializedAs("_maxLifeTime")] [SerializeField] protected float maxLifeTime;
        [FormerlySerializedAs("_damage")] [SerializeField] protected float damage;

        private Transform _parentTransform;
        
        [FormerlySerializedAs("_bulletExplosionPrefab")] public Object bulletExplosionPrefab;
        [FormerlySerializedAs("_bulletExplosionPosition")] public Transform bulletExplosionPosition;
        
        void Start()
        {
            _parentTransform = transform.parent;
            bulletExplosionPrefab = Resources.Load("Prefabs/ShellExplosion");
            bulletExplosionPosition = gameObject.GetComponent<BulletStandart>().transform;
        }
        void Update()
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}