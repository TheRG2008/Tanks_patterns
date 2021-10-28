using System;
using Markers;
using TankUnit.Interfaces;
using UnityEngine;

namespace TankUnit.Code
{
    public class TankView : TankClass, ITankView, ITakeDamage
    {
        public bool ai { get; set; }
        public float TakeDamage(float damage)
        {
            float _damage = damage;
            if (!ai) TankFire.Fire();
            return damage;
        }
    }
}