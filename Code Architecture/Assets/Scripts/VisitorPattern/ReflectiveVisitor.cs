using System;
using System.Reflection;
using UnityEngine;

namespace CodeArchitecture.Visitor
{
    public class ReflectiveVisitor :  IVisitor
    {
        public void Visit(IVisitable visitable)
        {
            MethodInfo visitMethod = GetType().GetMethod("Visit", new Type[] { visitable.GetType() });
            if (visitMethod != null && visitMethod != GetType().GetMethod("Visit", new Type[] { typeof(IVisitable) }))
            {
                visitMethod.Invoke(this, new object[] { visitable });
            }
            else
            {
                DefaultVisit(visitable);
            }
        }

        public void Visit<T>(IVisitable visitable, T value)
        {
            MethodInfo visitMethod = GetType().GetMethod("Visit", new Type[] { visitable.GetType(), typeof(T) });
            if (visitMethod != null && visitMethod != GetType().GetMethod("Visit", new Type[] { typeof(IVisitable), typeof(T) }))
            {
                visitMethod.Invoke(this, new object[] { visitable, value });
            }
            else
            {
                DefaultVisit(visitable);
            }
        }

        void DefaultVisit(IVisitable visitable)
        {
            Debug.Log("DefaultVisit: " + visitable.GetType().Name);
        }

        public void Visit(MoneyBoxController moneyBoxController)
        {
            moneyBoxController.UpdateText();
        }

        public void Visit(MoneyBoxController moneyBoxController, int amount)
        {
            moneyBoxController.AddMoney(amount);
            Debug.Log($"Added {amount} money. New balance: {moneyBoxController.Money}");
        }
    }
}
