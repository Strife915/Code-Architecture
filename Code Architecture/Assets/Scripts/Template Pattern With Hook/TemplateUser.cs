using Sirenix.OdinInspector;
using UnityEngine;

namespace CodeArchitecture.Template
{
    public class TemplateUser : MonoBehaviour
    {
        [Button]
        void TestTemplate() {
            CaffeinBeberageWithHook coffee = new CoffeeWithHook();
            CaffeinBeberageWithHook tea = new TeaWithHook();
            coffee.PrepareRecipe();
            tea.PrepareRecipe();
        }
    }
}