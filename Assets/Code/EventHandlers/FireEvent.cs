using System.Collections.Generic;
using UnityEngine;

namespace EventHandlers
{
    public class FireEvent
    {
        public delegate void StartTurn();

        public event StartTurn startTurn;
        private bool _isTurnOver = true;
        private List<TankClass.Code.TankClass> _tankList = new List<TankClass.Code.TankClass>();
        public  FireEvent(List<TankClass.Code.TankClass> tanks)
        {
            _tankList = tanks;
            Debug.Log($"Got {tanks.Count} tanks and have {_tankList.Count} in handler");
        }

        public void Fire()
        {
            if (!_isTurnOver) return;
            else
            {
                _tankList[0].Health.ChangeHp(10.0f);
                startTurn?.Invoke();
            }
            
        }
        
    }
}