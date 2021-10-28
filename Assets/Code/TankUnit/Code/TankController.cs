using TankUnit.Interfaces;

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
            _tankView.ai = ai;
        }
        
        public void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}