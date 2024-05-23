using System;
using System.Reflection;
using UnityEngine;

namespace CodeArchitecture.Visitor
{
    [CreateAssetMenu(menuName = "CodeArchitecture/Visitor/PowerUp", fileName = "Power Up")]
    public class PowerUp : ScriptableObject, IVisitor
    {
        public int healthBonus = 10;
        public int manaBonus = 10;

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
            Debug.Log("PowerUp.DefaultVisit");
        }

        // public void Visit(HealthComponent healthComponent)
        // {
        //     healthComponent.health += healthBonus;
        //     Debug.Log("PowerUp.Visit(healthComponent)");
        // }

        // public void Visit(ManaComponent manaComponent)
        // {
        //     manaComponent.mana += manaBonus;
        //     Debug.Log("PowerUp.Visit(manaComponent)");
        // }

        // public void Visit(IntrusiveHealthComponent intrusiveHealthComponent)
        // {
        //     intrusiveHealthComponent.AddHealth(healthBonus);
        // }
        //
        // public void Visit(IntrusiveManaComponent intrusiveManaComponent)
        // {
        //     intrusiveManaComponent.AddMana(manaBonus);
        // }
    }
}