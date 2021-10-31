namespace TankUnit.Interfaces
{
    public interface ITankFire
    {
        bool Fired { get; set; }
        public void Fire();

        delegate void MoveToNext();

        event MoveToNext MoveIt;
    }
}