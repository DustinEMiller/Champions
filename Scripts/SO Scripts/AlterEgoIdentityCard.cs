using Enums;
using UnityEngine;
namespace ScriptableObjects
{
    [CreateAssetMenu(menuName = "Cards/Alter-Ego Identity")]
    public class AlterEgoIdentityCard  : ICard
    {
        [Header("Card info")]
        public Hero Hero;
        public HeroIdentityCard AlterEgoCard;
        
        [Header("Stats")]
        public int Recovery;
        public int HandSize;
        public int HitPoints;
    }
    
}
