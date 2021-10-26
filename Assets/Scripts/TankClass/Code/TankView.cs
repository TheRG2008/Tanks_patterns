using System.Collections;
using TankClass.View.Interface;
using UnityEngine;

namespace TankClass.View
{
    public class TankView : TankClass, ITankView
    {
        
        public Transform Transform { get; set; }
        public Vector2 MoveVector { get; set; }
        public CharacterController MoveControl { get; set; }
        
        public void ChildCourutine(IEnumerator enumerator)
        {
            throw new System.NotImplementedException();
        }

    }
}