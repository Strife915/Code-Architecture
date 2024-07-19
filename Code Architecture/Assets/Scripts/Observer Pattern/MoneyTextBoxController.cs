using TMPro;
using UnityEngine;
using Zenject;

namespace CodeArchitecture.Observer
{
    public class MoneyTextBoxController : MonoBehaviour, IObserver, IDisplayElement
    {
        [SerializeField] TextMeshProUGUI _moneyText;
        ISubject _playerMoney;
        int _money;

        [Inject]
        public void Construct(PlayerMoney playerMoney)
        {
            _playerMoney = playerMoney;
            _playerMoney.RegisterObserver(this);
        }

        public void UpdateObserver(int money)
        {
            _money = money;
            Display();
        }

        public void Display()
        {
            _moneyText.text = $"Money: {_money}";
        }

        public void UpdateObserver(object data)
        {
            if (data is int money)
            {
                UpdateObserver(money);
            }
        }
    }
}