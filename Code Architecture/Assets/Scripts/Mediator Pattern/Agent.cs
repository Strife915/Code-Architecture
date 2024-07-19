using System;
using UnityEngine;

namespace CodeArchitecture.Mediator
{
    public class Agent : MonoBehaviour, IVisitable
    {
        [SerializeField] Mediator<Agent> _mediator;
        [SerializeField] bool _isGreen;
        SpriteRenderer _spriteRenderer;
        public bool IsGreen => _isGreen;

        void Awake()
        {
            _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
            UpdateSpriteColor();
        }

        void Start()
        {
            _mediator.Register(this);
            if (_isGreen)
                Send(new MessagePayload { Content = "Registered", Source = this });
        }

        public void Accept(IVisitor message)
        {
            message.Visit(this);
        }

        void Send(IVisitor message) => message.Visit(this);
        void Send(IVisitor message, Func<Agent, bool> predicate) => _mediator.BroadCast(this, message, predicate);

        void OnDestroy()
        {
            _mediator.Unregister(this);
        }

        void UpdateSpriteColor()
        {
            _spriteRenderer.color = _isGreen ? Color.green : Color.red;
        }
    }
}