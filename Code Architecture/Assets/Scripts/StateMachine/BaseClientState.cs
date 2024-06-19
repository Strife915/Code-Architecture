using UnityEngine;

namespace CodeArchitecture.StateMachine
{
    public abstract class BaseClientState : BaseState
    { 
        SpriteRenderer _spriteRenderer;
        protected Color _color;

        public BaseClientState(SpriteRenderer spriteRenderer)
        {
            _spriteRenderer = spriteRenderer;
        }
        protected void SetSpriteColor()
        {
            _spriteRenderer.color = _color;
        }

        public override void Enter()
        {
            SetSpriteColor();
        }
    }

    public class RedState : BaseClientState
    {
        public RedState(SpriteRenderer spriteRenderer) : base(spriteRenderer)
        {
            _color = Color.red;
        }
    }
    public class BlueState : BaseClientState
    {
        public BlueState(SpriteRenderer spriteRenderer) : base(spriteRenderer)
        {
            _color = Color.blue;
        }
    }
    public class GreenState : BaseClientState
    {
        public GreenState(SpriteRenderer spriteRenderer) : base(spriteRenderer)
        {
            _color = Color.green;
        }
    }
}