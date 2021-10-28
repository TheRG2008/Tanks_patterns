using Markers;
using TankUnit.Interfaces;
using UnityEngine;

namespace TankUnit.Code
{
    public class TankView : TankClass, ITankView, ITakeDamage
    {
        public event ITankView.Damaged getNext;
        public bool ai { get; set; }
     
      public float TakeDamage(float damage)
      {
          if (ai) getNext?.Invoke();
          return damage;
      }
    }
}