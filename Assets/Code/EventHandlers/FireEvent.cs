using System.Collections.Generic;
using TankUnit.Code;
using UnityEngine;

namespace EventHandlers
{
    public class FireEvent
    {
        private bool _isTurnOver = false;
        private int _counter = 0;
        private readonly List<TankClass> _tankList;
        public  FireEvent(List<TankClass> tanks)
        {
            _tankList = tanks;
            foreach (var tank in _tankList)
            {
                tank.TankFire.MoveIt += choose_next;
            }
        }
        public void Fire()
        {
            if (_isTurnOver)
            {
                if (_counter == _tankList.Count)
                {
                    NewTurn(_tankList);
                    Fire();
                }
                Debug.Log($"BAAAAD counter is {_counter} must be {_tankList.Count}");
                return;
            }
            _tankList[0].transform.LookAt(_tankList[Random.Range(1,_tankList.Count)].transform.position);
            _tankList[0].TankFire.Fire();
            _isTurnOver = true;
        }
        private void choose_next()
        {
            _counter = 0;
            for(int i =0;i<_tankList.Count;i++)
            {
                
                    if (!_tankList[i].TankFire.Fired)
                    {
                        AutoFire(i);
                        Debug.Log($"{_counter}") ;
                        break;
                    }
                    _counter++;
            }
            
        }
        void AutoFire(int counter)
        {
            Debug.Log("auto");
            _tankList[counter].TankFire.Fire();
        }
        private void NewTurn(List<TankClass> tanklist)
        {
            Debug.Log("restart");
            foreach (var tank in tanklist)
            {
                _counter = 0;
                _isTurnOver = false;
                tank.TankFire.Fired = false;
                tank.TankControl.NewTurn();
            }
        }
        
    }
}