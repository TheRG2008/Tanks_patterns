using Markers;
using UnityEngine;

namespace Weapon
{
    public class Cannon : MonoBehaviour
    {
        [SerializeField] private GameObject _bulletPref;
        [SerializeField] private Transform _bulletStartPosition;
        public float _firerate => 5f;

        public void Shoot()
        {
           Instantiate(_bulletPref, _bulletStartPosition.position, transform.rotation);
        }
    }
}