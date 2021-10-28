using System.Collections;
using Markers;
using TankUnit.Interfaces;
using UnityEngine;

namespace TankUnit.Code
{
    public class TankView : TankClass, ITankView
    {
        
        public Transform Transform { get; set; }
        public Vector2 MoveVector { get; set; }
        public bool ai { get; set; }
        public CharacterController MoveControl { get; set; }
        
        public void ChildCourutine(IEnumerator enumerator)
        {
            throw new System.NotImplementedException();
        }
        
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