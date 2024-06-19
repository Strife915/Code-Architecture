using System;
using UnityEngine;

namespace CodeArchitecture.Visitor
{
    public class VisitorUser : MonoBehaviour
    {
        [SerializeField] MoneyBoxController _moneyBoxController;
        [SerializeField] int _amount;
         ReflectiveVisitor _reflectiveVisitor;

         void Start()
         {
                _reflectiveVisitor = new ReflectiveVisitor();
         }

         void Update()
        {
            //When player input space key, the money text will be updated
            if (Input.GetKeyDown(KeyCode.Space))
            { 
                _moneyBoxController.Accept(_reflectiveVisitor, _amount);
            }
        }
    }
}

