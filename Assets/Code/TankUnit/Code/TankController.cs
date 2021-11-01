using TankUnit.Interfaces;
using UnityEngine;

namespace TankUnit.Code
{
    public class TankController : ITankControl 
    {
        private readonly ITankModel _tankModel;
        private readonly ITankView _tankView;

        public TankController(ITankModel tankModel, ITankView tankView, bool ai)
        {
            _tankModel = tankModel;
            _tankView = tankView;
            _tankView.AI = ai;
            _tankView.Firstblood = true;
        }

        public void RotateTo(Transform transform)
        {
            _tankView.Transform = transform;
        }

        public void NewTurn()
        {
            _tankView.Firstblood = !_tankView.Firstblood;
        }
    }
}