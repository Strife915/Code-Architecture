using UnityEngine;

namespace CodeArchitecture.Visitor
{
    public class ManaComponent : MonoBehaviour, IVisitable
    {
        public int mana = 100;
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            Debug.Log("Mana Component.Accept");
        }
    }
}