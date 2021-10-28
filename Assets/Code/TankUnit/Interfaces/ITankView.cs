namespace TankUnit.Interfaces
{
    public interface ITankView
    {
        delegate void Damaged();

        event Damaged getNext;
        public bool ai {get; set; }
    }
}