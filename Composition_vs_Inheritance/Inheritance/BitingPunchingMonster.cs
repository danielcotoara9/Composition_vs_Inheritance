namespace Composition_vs_Inheritance.Inheritance
{
    public class BitingPunchingMonster : BitingMonster
    {
        private readonly int _punchDamage;

        public BitingPunchingMonster(int hitPoints, int biteDamage, int punchDamage) : base(hitPoints, biteDamage)
        {
            _punchDamage = punchDamage;
        }
    }
}
