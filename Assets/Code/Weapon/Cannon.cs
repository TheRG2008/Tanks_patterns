using Markers;
using UnityEngine;
using UnityEngine.Serialization;

namespace Weapon
{
    public class Cannon : MonoBehaviour
    {
        [SerializeField] private GameObject bulletPref;
        [SerializeField] private Transform bulletStartPosition;

        public void Shoot()
        {
           Instantiate(bulletPref, bulletStartPosition.position, transform.rotation);
        }
    }
}