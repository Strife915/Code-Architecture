using UnityEngine;
using UnityEngine.UI;

namespace CodeArchitecture.Command
{
    public class OffButton : MonoBehaviour
    {
        UndoButtonController _undoButtonController;
        Button _button;
        ICommand _offCommand;

        void Awake() {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(Off);
            _undoButtonController = GetComponentInParent<UndoButtonController>();
        }

        void Off() {
            _offCommand.Execute();
            _undoButtonController.SetUndoCommand(_offCommand);
        }

        public void SetOffCommand(ICommand command) {
            _offCommand = command;
        }
    }
}