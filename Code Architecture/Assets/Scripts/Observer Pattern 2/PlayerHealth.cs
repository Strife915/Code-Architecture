using UnityEngine;

namespace CodeArchitecture.Observer_2
{
    public class PlayerHealth : MonoBehaviour
    {
        public Observer<int> Health = new Observer<int>(100);
        public Observer<bool> IsAlieve = new Observer<bool>(true);

        void Start()
        {
            Health.Invoke();
            IsAlieve.Invoke();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Health.Value += 10;
                if (!IsAlieve.Value)
                {
                    IsAlieve.Value = true;
                }
            }

            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                if (Health.Value > 0)
                    Health.Value -= 10;
                if (Health.Value <= 0)
                {
                    IsAlieve.Value = false;
                }
            }
        }
    }
}