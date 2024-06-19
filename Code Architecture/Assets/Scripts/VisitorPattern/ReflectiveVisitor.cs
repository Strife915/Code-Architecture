using System;
using System.Reflection;
using UnityEngine;

namespace CodeArchitecture.Visitor
{
    public class ReflectiveVisitor :   IVisitor
    {
        public void Visit(object o)
        {
            MethodInfo visitMethod = GetType().GetMethod("Visit", new Type[] { o.GetType() });
            if (visitMethod != null && visitMethod != GetType().GetMethod("Visit", new Type[] { typeof(object) }))
            {
                visitMethod.Invoke(this, new object[] { o });
            }
            else
            {
                DefaultVisit(o);
            }
        }

        void DefaultVisit(object o)
        {
            Debug.Log("DefaultVisit");
        }
        
        public void Visit(MoneyBoxController moneyBoxController)
        {
            moneyBoxController.UpdateText();
        }
    }
}
