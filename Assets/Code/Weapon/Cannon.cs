using Markers;
using UnityEngine;

namespace Weapon
{
    public class Cannon:MonoBehaviour
    {
        [SerializeField] private GameObject _bulletPref;
        [SerializeField] private Transform _bulletStartPosition;
        public float _firerate => 5f;

        private void Awake()
        {
            //var gameObject = Resources.Load<GameObject>("Resources/Prefabs/Shell");
            //_bulletPref = Object.Instantiate(gameObject);
            //_bulletStartPosition = FindObjectOfType<FirePoint>().transform;
        }
        public void Shoot()
        {
            var bulletInstantiate = Instantiate(_bulletPref, _bulletStartPosition.position, transform.rotation);
            //bulletInstantiate.GetComponent<BulletStandart>().Init();
        }
    }
}