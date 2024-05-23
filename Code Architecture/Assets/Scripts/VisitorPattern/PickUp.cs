using System;
using UnityEngine;

namespace CodeArchitecture.Visitor
{
    public class PickUp : MonoBehaviour
    {
        public PowerUp powerUp;
        

        void OnTriggerEnter2D(Collider2D other)
        {
            IVisitable visitable = other.GetComponent<IVisitable>();
            if(visitable!=null)
                visitable.Accept(powerUp);
        }
    }
}