using System.Collections;
using System.Collections.Generic;
using Enums;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(menuName = "Cards/Hero Card")]
    public class HeroCard : ICard
    {
        public Hero Hero;
        public HeroCardType HeroCardType;
        public int ResourceCost;
        public int Thwart;
        public int Attack;
        public int HitPoints;
        public List<ResourceType> ResourceTypes;
    }
}

