namespace Composition_vs_Inheritance.Inheritance
{
    public class PunchingMonster : Monster
    {
        public int PunchDamage;

        public PunchingMonster(int hitPoints, int punchDamage) : base(hitPoints)
        {
            PunchDamage = punchDamage;
        }
    }
}
