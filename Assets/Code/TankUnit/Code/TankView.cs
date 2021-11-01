using System;
using Markers;
using TankUnit.Interfaces;
using UnityEngine;
using Weapon;
using Object = UnityEngine.Object;

namespace TankUnit.Code
{
    public class TankView : TankClass, ITankView, ITakeDamage
    {
        public Transform Transform { get; set; }
        public event ITankView.Damaged GETNext;

        private void Awake()
        {
            Transform = transform;
        }

        public bool AI { get; set; }
        public bool Firstblood { get; set; }

        public float TakeDamage(float damage)
        {
            if (!AI && Firstblood) Firstblood = !Firstblood;
          
            GETNext?.Invoke();
            return damage;
        }
    }
}