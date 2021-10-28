namespace TankUnit.Interfaces
{
    public interface ITankFire
    {
        bool Fired { get; set; }
        public void Fire();
    }
}