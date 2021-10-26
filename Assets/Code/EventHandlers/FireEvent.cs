using System.Collections.Generic;
using CommonClasses;
using UnityEngine;

namespace EventHandlers
{
    public class FireEvent
    {
        private bool _isTurnOver = true;
        private bool _changeTurn = true;
        private List<TankClass.Code.TankClass> _tankList = new List<TankClass.Code.TankClass>();
        public  FireEvent(List<TankClass.Code.TankClass> tanks)
        {
            _tankList = tanks;
            Debug.Log($"Got {tanks.Count} tanks and have {_tankList.Count} in handler");
        }

        public void Fire()
        {
            if (!_isTurnOver) return;
            if (_changeTurn)
            {
                _tankList[0].Health.ChangeHp(_tankList[0].Health.CurrentHp - 10.0f);
                Debug.Log($"Tank 0 HP is {_tankList[0].Health.CurrentHp}");
                _changeTurn = !_changeTurn;
            }
            else
            {
                _tankList[1].Health.ChangeHp(_tankList[0].Health.CurrentHp - 10.0f);
                Debug.Log($"Tank 1 HP is {_tankList[0].Health.CurrentHp}");
                _changeTurn = !_changeTurn;
            }

        }
        
    }
}