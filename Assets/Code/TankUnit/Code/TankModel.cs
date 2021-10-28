using TankUnit.Interfaces;
using UnityEngine;

namespace TankUnit.Code
{
    public struct TankModel : ITankModel
    {
        public Color Color { get; set; }
        public float Size { get; set; }
        public TankModel(Color color, float size) 
        {
            Color = color;
            Size = size;
        }
    }
}