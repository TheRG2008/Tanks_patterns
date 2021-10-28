using System.Collections;
using UnityEngine;

namespace TankUnit.Interfaces
{
    public interface ITankView
    {
        public void ChildCourutine(IEnumerator enumerator);
        public Transform Transform { get; set; }
        public Vector2 MoveVector { get; set; }
        public bool ai {get; set; }
        public CharacterController MoveControl { get; set; }
    }
}