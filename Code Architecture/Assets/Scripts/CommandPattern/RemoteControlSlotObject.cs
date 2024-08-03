using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CodeArchitecture.Command
{
    public class RemoteControlSlotObject : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _labelText;
        [SerializeField] Button _onButton, _offButton;

        public void SetCommand(ICommand onCommand, ICommand offCommand, string label) {
            _labelText.text = label;
            _onButton.onClick.AddListener(onCommand.Execute);
            _offButton.onClick.AddListener(offCommand.Execute);
        }
    }
}