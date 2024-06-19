using UnityEngine;

namespace CodeArchitecture.StateMachine
{
    public class StateMachineClient : MonoBehaviour
    {
        [SerializeField] SpriteRenderer _spriteRenderer;

        StateMachine _stateMachine;
        IState _blueState;
        IState _redState;
        IState _greenState;

        void Awake()
        {
            _stateMachine = new StateMachine();
            _blueState = new BlueState(_spriteRenderer);
            _redState = new RedState(_spriteRenderer);
            _greenState = new GreenState(_spriteRenderer);
            _stateMachine.SetState(_greenState);
            At(_greenState,_redState, new FuncPredicate((() => Input.GetKeyDown(KeyCode.R))));
            At(_redState,_greenState, new FuncPredicate((() => Input.GetKeyDown(KeyCode.G))));
            At(_blueState,_greenState, new FuncPredicate((() => Input.GetKeyDown(KeyCode.G))));
            At(_blueState,_redState, new FuncPredicate((() => Input.GetKeyDown(KeyCode.R))));
            Any(_blueState, new FuncPredicate((() => Input.GetKeyDown(KeyCode.B))));
            
        }
        void At(IState from, IState to, IPredicate condition) => _stateMachine.AddTransition(from, to, condition);
        void Any(IState to, IPredicate condition) => _stateMachine.AddAnyTransition(to, condition);
        
        void Update()
        {
            _stateMachine.Update();
        }
    }
}

