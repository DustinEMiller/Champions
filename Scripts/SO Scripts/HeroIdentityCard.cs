using Enums;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(menuName = "Cards/Hero Identity")]
    public class HeroIdentityCard : ICard
    {
        [Header("Card info")]
        public Hero Hero;
        public AlterEgoIdentityCard AlterEgoCard;
        
        [Header("Stats")]
        public int Attack;
        public int Thwart;
        public int Def;
        public int HandSize;
        public int HitPoints;

    }
}
