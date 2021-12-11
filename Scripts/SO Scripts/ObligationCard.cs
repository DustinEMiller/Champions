using Enums;
using UnityEngine;
namespace ScriptableObjects
{
    [CreateAssetMenu(menuName = "Cards/Obligation Card")]
    public class ObligationCard  : ICard
    {
        [Header("Card info")]
        public Hero Hero;
    }
    
}
