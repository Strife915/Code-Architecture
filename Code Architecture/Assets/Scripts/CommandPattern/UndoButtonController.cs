using UnityEngine;
using UnityEngine.UI;

namespace CodeArchitecture.Command
{
    public class UndoButtonController : MonoBehaviour
    {
        [SerializeField] Button _button;
        ICommand _undoCommand;

        void Awake() {
            _undoCommand = new NoCommand();
            _button.onClick.AddListener(Undo);
        }

        void Undo() {
            _undoCommand.Undo();
        }

        public void SetUndoCommand(ICommand command) {
            _undoCommand = command;
        }
    }
}