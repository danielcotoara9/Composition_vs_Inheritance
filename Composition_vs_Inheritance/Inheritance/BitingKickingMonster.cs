namespace Composition_vs_Inheritance.Inheritance
{
    public class BitingKickingMonster : BitingMonster
    {
        private readonly int _kickDamage;

        public BitingKickingMonster(int hitPoints, int biteDamage, int kickDamage) : base(hitPoints, biteDamage)
        {
            _kickDamage = kickDamage;
        }
    }
}
