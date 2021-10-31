using System.Collections.Generic;
using CommonClasses;
using EventHandlers;
using Markers;
using TankUnit;
using TankUnit.Code;
using TankUnit.Interfaces;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    private bool _makeAI = false;
  
    private ITankFactory _tankFactory;
    private SpawnPoint[] _spawnPoints;
    private FireEvent _fireEvent;
    private List<TankClass> _tankList = new List<TankClass>();
    private void Start()
    {
        _spawnPoints = FindObjectsOfType<SpawnPoint>();
        _tankFactory = new TankFactory();
        SpawnTanks(_spawnPoints);
        _fireEvent = new FireEvent(_tankList);
    }


    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _fireEvent.Fire();
        }
    }

    private void SpawnTanks(SpawnPoint[] spawnPoints)
    {
     _tankList.Add(_tankFactory.Create(new Health(100.0f, 100.0f), FindObjectOfType<PlayerPoint>().transform.position, Color.red, FindObjectOfType<PlayerPoint>().transform, _makeAI));   
        foreach (var spawnPoint in  spawnPoints)
        {
            var transform1 = spawnPoint.transform;
           
                _tankList.Add(_tankFactory.Create(new Health(100.0f, 100.0f), transform1.position, Color.red,FindObjectOfType<PlayerPoint>().transform,!_makeAI));
        }
    }
}