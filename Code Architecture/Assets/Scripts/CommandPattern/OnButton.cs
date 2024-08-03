using UnityEngine;
using UnityEngine.UI;

namespace CodeArchitecture.Command
{
    public class OnButton : MonoBehaviour
    {
        UndoButtonController _undoButtonController;
        Button _button;
        ICommand _onCommand;

        void Awake() {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(On);
            _undoButtonController = GetComponentInParent<UndoButtonController>();
        }

        void On() {
            _onCommand.Execute();
            _undoButtonController.SetUndoCommand(_onCommand);
        }

        public void SetOnCommand(ICommand command) {
            _onCommand = command;
        }
    }
}