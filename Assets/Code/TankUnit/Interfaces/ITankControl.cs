namespace TankUnit.Interfaces
{
    public interface ITankControl
    {
        delegate void MoveToNext();

        event MoveToNext MoveIt;
        public void MoveTurn();
    }
}