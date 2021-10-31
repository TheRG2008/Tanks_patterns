namespace TankUnit.Interfaces
{
    public interface ITankView
    {
        delegate void Damaged();

        event Damaged GETNext;
        public bool AI {get; set; }

        public bool Firstblood { get; set; }
    }
}