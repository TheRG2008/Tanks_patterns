using System;
using Markers;
using TankUnit.Interfaces;
using UnityEngine;

namespace TankUnit.Code
{
    public class TankView : TankClass, ITankView
    {
        public bool ai { get; set; }

        public void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<BulletMarker>(out var val) && !ai)
            {
                TankFire.Fire();
                Destroy(other.gameObject);
            }
        }
    }
}