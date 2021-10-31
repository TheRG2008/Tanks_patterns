using Markers;
using TankUnit.Interfaces;
using UnityEngine;
using Weapon;
using Object = UnityEngine.Object;

namespace TankUnit.Code
{
    public class TankView : TankClass, ITankView, ITakeDamage
    {

        public event ITankView.Damaged GETNext;
       
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