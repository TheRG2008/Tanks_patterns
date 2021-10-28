using Markers;
using TankUnit.Interfaces;
using UnityEngine;

namespace TankUnit.Code
{
    public class TankView : TankClass, ITankView
    {
        public event ITankView.Damaged getNext;
        public bool ai { get; set; }
      public void OnCollisionEnter(Collision other)
        {
            Debug.Log($"Got Damage and ai is {ai}");
            if (ai)
            {
               // TankFire.Fire();
                getNext?.Invoke();
            }

        }
    }
}