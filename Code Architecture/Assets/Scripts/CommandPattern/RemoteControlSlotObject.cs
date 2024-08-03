using TMPro;
using UnityEngine;

namespace CodeArchitecture.Command
{
    public class RemoteControlSlotObject : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _labelText;
        OnButton _onButton;
        OffButton _offButton;

        void Awake() {
            _onButton = GetComponentInChildren<OnButton>();
            _offButton = GetComponentInChildren<OffButton>();
        }

        public void SetCommand(ICommand onCommand, ICommand offCommand, string label) {
            _labelText.text = label;
            _onButton.SetOnCommand(onCommand);
            _offButton.SetOffCommand(offCommand);
        }
    }
}