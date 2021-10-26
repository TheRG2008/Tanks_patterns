using TankClass.Interfaces;

namespace TankClass.Code
{
    public class TankController : ITankControl
    {
        private readonly ITankModel _tankModel;
        private ITankView _tankView;
        public TankController(ITankModel tankModel, ITankView tankView)
        {
            _tankModel = tankModel;
            _tankView = tankView;
        }
        
        public void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}