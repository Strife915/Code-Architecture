using UnityEngine;
using UnityEngine.Serialization;

namespace CodeArchitecture.Visitor
{
    public class IntrusiveHealthComponent : MonoBehaviour, IVisitable
    {
        [SerializeField] int _health = 100;

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            Debug.Log("Health Component.Accept");
        }

        public void AddHealth(int value)
        {
            _health += value;
        }
    }
}