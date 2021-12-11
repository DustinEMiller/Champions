using Enums;
using UnityEngine;

namespace ScriptableObjects
{
    public abstract class ICard  : ScriptableObject
    {
        [Header("Card info")]
        public string CardName;
        public Set Set;
        public int Copies;

        [Header("Image info")]
        public Sprite SmallCardImage;
        public Sprite LargeCardImage;
    }
}
