using TMPro;
using UnityEngine;

namespace CodeArchitecture.Observer_2
{
    public class HealthDisplay : MonoBehaviour
    {
        TMP_Text _healthText;

        void Awake()
        {
            _healthText = GetComponent<TMP_Text>();
        }

        public void UpdateHealthDisplay(int health)
        {
            _healthText.text = $"Health: {health}";
        }
    }
}