using TMPro;
using UnityEngine;

namespace CodeArchitecture.Observer_2
{
    public class MoneyDisplay : MonoBehaviour
    {
        TMP_Text _moneyText;

        void Awake()
        {
            _moneyText = GetComponent<TMP_Text>();
        }

        public void UpdateMoneyDisplay(float money)
        {
            _moneyText.text = $"Money: {money}";
        }
    }
}