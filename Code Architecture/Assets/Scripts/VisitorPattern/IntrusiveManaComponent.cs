using UnityEngine;
using UnityEngine.Serialization;

namespace CodeArchitecture.Visitor
{
    public class IntrusiveManaComponent : MonoBehaviour, IVisitable
    {
        [SerializeField] int _mana = 100;

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            Debug.Log("Mana Component.Accept");
        }

        public void AddMana(int value)
        {
            _mana += value;
        }
    }
}