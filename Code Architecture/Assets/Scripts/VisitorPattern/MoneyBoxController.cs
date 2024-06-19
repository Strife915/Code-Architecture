using TMPro;
using UnityEngine;

namespace CodeArchitecture.Visitor
{
    public class MoneyBoxController : MonoBehaviour, IVisitable
    {
        [SerializeField] TextMeshProUGUI _moneyText;
        public int Money { get; private set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Accept<T>(IVisitor visitor, T value)
        {
            visitor.Visit(this, value);
        }

        public void UpdateText()
        {
            _moneyText.text = "Money: " + Money;
        }

        public void AddMoney(int amount)
        {
            Money += amount;
            UpdateText();
        }

        public void DeductMoney(int amount)
        {
            Money -= amount;
            UpdateText();
        }
    }
}