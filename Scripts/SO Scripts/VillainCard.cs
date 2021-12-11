using Enums;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(menuName = "Cards/Villain")]
    public class VillainCard : ICard
    {
        
        public VillainCardType Type;

        [Header("Villain/Minion Info")] 
        public int Scheme;
        public int Attack;
        public int HitPoints;
        public int Phase;
        
        [Header("Scheme/Side Scheme")] 
        public int ThreatCondition;
        public int AccelerationField;
        public int StartingThreat;
        public SideSchemeIcons SideSchemeIcon;
        public VillainCard NextScheme;

        [Header("Misc")] 
        public int Boosts;
        public bool Star = false;
        public Hero Hero;
    }
}
