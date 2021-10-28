using Markers;
using TankUnit.Interfaces;
using UnityEngine;

namespace TankUnit.Code
{
    public class TankView : TankClass, ITankView
    {
        public bool ai { get; set; }
      public void OnCollisionEnter(Collision other)
        {
            if (TryGetComponent<BulletMarker>(out var bullet) && !ai)
            {
                //TURN OVER
            }
            else
            {
                TankFire.Fire();
                Debug.Log("AUTOFIRE");
                
            }
        }
    }
}