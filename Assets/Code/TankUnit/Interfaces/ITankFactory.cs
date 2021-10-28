using CommonClasses;
using TankUnit.Code;
using UnityEngine;

namespace TankUnit.Interfaces
{
    public interface ITankFactory
    {
<<<<<<< Updated upstream
        public TankClass Create(Health heath, Vector2 position, Color color, bool ai);
=======
        public TankClass Create(Health heath, Vector3 position, Color color, Vector3 rotation, bool ai);
>>>>>>> Stashed changes
    }
}