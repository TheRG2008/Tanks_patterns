namespace CommonClasses
{
    public class Health
    {
        public float MaxHp { get; }
        public float CurrentHp { get; private set; }

        public Health(float hp, float current)
        {
            MaxHp = hp;
            CurrentHp = current;
        }

        public void ChangeHp(float value) => CurrentHp = value;
    }
}