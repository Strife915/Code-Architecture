using TMPro;
using UnityEngine;

namespace CodeArchitecture.Visitor
{
    public class MoneyBoxController : MonoBehaviour, IVisitable
    {
        [SerializeField] TextMeshProUGUI _moneyText;
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        public void UpdateText()
        {
            _moneyText.text = "Money: " + Random.Range(0, 1000);
        }
    }
}