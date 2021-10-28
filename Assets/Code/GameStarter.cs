using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CommonClasses;
using EventHandlers;
using Markers;
using TankClass;
using TankClass.Interfaces;
using UnityEngine;
using Weapon;

public class GameStarter : MonoBehaviour
{
    private bool _makeAI = false;
    
    private ITankFactory _tankFactory;
    private SpawnPoint[] _spawnPoints;
    private FireEvent _fireEvent;
    private Cannon _cannon;
    private List<TankClass.Code.TankClass> _tankList = new List<TankClass.Code.TankClass>();
    private void Start()
    {
        _spawnPoints = FindObjectsOfType<SpawnPoint>();
        _tankFactory = new TankFactory();
        SpawnTanks(_spawnPoints);
        _fireEvent = new FireEvent(_tankList);
        _cannon = FindObjectOfType<Cannon>();
    }


    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //_fireEvent.Fire();
            Debug.Log("FIREEE from starter");
            _cannon.Shoot();
        }
    }

    private void SpawnTanks(SpawnPoint[] spawnPoints)
    {
        
        foreach (var spawnPoint in  spawnPoints)
        {
            if (!_makeAI)
            {
                _tankList.Add(_tankFactory.Create(new Health(100.0f, 100.0f), spawnPoint.transform.position, Color.red, _makeAI));
                _makeAI = !_makeAI;
            }
            else
            {
                _tankList.Add(_tankFactory.Create(new Health(100.0f, 100.0f), spawnPoint.transform.position, Color.red, _makeAI));
            }
        
        }
        Debug.Log($"{_tankList.Count} are here");
    }
}