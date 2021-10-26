using TankClass.Controller.Interface;
using TankClass.Model;
using TankClass.View.Interface;

namespace TankClass.Controller
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