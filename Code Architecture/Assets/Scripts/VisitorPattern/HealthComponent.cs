using UnityEngine;

namespace CodeArchitecture.Visitor
{
    public class HealthComponent : MonoBehaviour , IVisitable
    {
        public int health = 100;
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            Debug.Log("Health Component.Accept");
        }
    }
}
