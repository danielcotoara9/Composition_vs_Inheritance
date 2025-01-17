﻿using System;
using System.Collections.Generic;

namespace Composition_vs_Inheritance.Composition
{
    public class Monster
    {
        private readonly int _hitPoints;

        public bool CanBite => AttackTypes.ContainsKey(AttackType.Biting);
        public bool CanKick => AttackTypes.ContainsKey(AttackType.Kicking);
        public bool CanPunch => AttackTypes.ContainsKey(AttackType.Punching);
        public bool CanSpit => AttackTypes.ContainsKey(AttackType.Spitting);

        public int BiteDamage
        {
            get
            {
                if (CanBite)
                    return AttackTypes[AttackType.Biting];
                throw new NotSupportedException("Monster cannot bite");
            }
        }    
        public int KickDamage
        {
            get
            {
                if (CanBite)
                    return AttackTypes[AttackType.Kicking];
                throw new NotSupportedException("Monster cannot kick");
            }
        }       
        public int PunchDamage
        {
            get
            {
                if (CanBite)
                    return AttackTypes[AttackType.Punching];
                throw new NotSupportedException("Monster cannot punch");
            }
        }

        public int SpitDamage
        {
            get
            {
                if (CanBite)
                    return AttackTypes[AttackType.Spitting];
                throw new NotSupportedException("Monster cannot spit");
            }
        }

        public Dictionary<AttackType, int> AttackTypes { get; set; }
        public Monster(int hitPoints)
        {
            _hitPoints = hitPoints;
            AttackTypes = new Dictionary<AttackType, int>();
        }

        public void AddAttackTypes(AttackType attackType, int amountOfDamage)
        {
            AttackTypes[attackType] = amountOfDamage;
        }
    }

}
