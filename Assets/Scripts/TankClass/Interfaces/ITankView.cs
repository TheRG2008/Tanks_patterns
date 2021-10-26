using System.Collections;
using UnityEngine;

namespace TankClass.View.Interface
{
    public interface ITankView
    {
        public void ChildCourutine(IEnumerator enumerator);
        public Transform Transform { get; set; }
        public Vector2 MoveVector { get; set; }
        public CharacterController MoveControl { get; set; }
    }
}