namespace Composition_vs_Inheritance.Inheritance
{
    public class BitingMonster : Monster
    {
        public int BiteDamage;

        public BitingMonster(int hitPoints, int biteDamage) : base(hitPoints)
        {
            BiteDamage = biteDamage;
        }
    }
}
