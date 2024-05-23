using UnityEngine;

namespace CodeArchitecture.Visitor
{
    [CreateAssetMenu(menuName = "CodeArchitecture/Visitor/PowerUp", fileName = "Power Up")]
    public class PowerUp : ScriptableObject , IVisitor
    {
        public int healthBonus = 10;
        public int manaBonus = 10;
        
        public void Visit(HealthComponent healthComponent)
        {
            healthComponent.health += healthBonus;
            Debug.Log("PowerUp.Visit(healthComponent)");
        }

        public void Visit(ManaComponent manaComponent)
        {
            manaComponent.mana += manaBonus;
            Debug.Log("PowerUp.Visit(manaComponent)");
        }
    }
}