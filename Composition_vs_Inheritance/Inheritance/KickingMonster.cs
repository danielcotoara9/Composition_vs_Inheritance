namespace Composition_vs_Inheritance.Inheritance
{
    public class KickingMonster : Monster
    {
        public int KickDamage;

        public KickingMonster(int hitPoints, int kickDamage) : base(hitPoints)
        {
            KickDamage = kickDamage;
        }
    }
}
