namespace Composition_vs_Inheritance.Inheritance
{
    public class BitingKickPunchingMonster : BitingMonster
    {
        private readonly int _kickDamage;
        private readonly int _punchDamage;

        public BitingKickPunchingMonster(int hitPoints, int biteDamage, int kickDamage, int punchDamage) : base(hitPoints, biteDamage)
        {
            _kickDamage = kickDamage;
            _punchDamage = punchDamage;
        }
    }
}
