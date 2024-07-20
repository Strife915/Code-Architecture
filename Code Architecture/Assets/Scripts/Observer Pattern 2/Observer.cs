using System;
using UnityEngine;
using UnityEngine.Events;
using System.Reflection;

#if UNITY_EDITOR
using UnityEditor.Events;
#endif

namespace CodeArchitecture.Observer_2
{
    [Serializable]
    public class Observer<T>
    {
        [SerializeField] T _value;
        [SerializeField] UnityEvent<T> _onValueChanged;
        public static implicit operator T(Observer<T> observer) => observer._value;

        public T Value
        {
            get => _value;
            set => Set(value);
        }

        public Observer(T value, UnityAction<T> callback = null)
        {
            _value = value;
            _onValueChanged = new UnityEvent<T>();
            if (callback != null) _onValueChanged.AddListener(callback);
        }

        public void Set(T value)
        {
            if (Equals(this._value, value)) return;
            _value = value;
            Invoke();
        }

        public void Invoke()
        {
            Debug.Log($"Invoking {_onValueChanged.GetPersistentEventCount()} listeners");
            _onValueChanged.Invoke(_value);
        }

        void AddListener(UnityAction<T> callback)
        {
            if (callback == null) return;
            if (_onValueChanged == null) _onValueChanged = new UnityEvent<T>();

#if UNITY_EDITOR
            UnityEventTools.AddPersistentListener(_onValueChanged, callback);
#endif
            _onValueChanged.AddListener(callback);
        }

        void RemoveListener(UnityAction<T> callback)
        {
            if (callback == null) return;
            if (_onValueChanged == null) return;
#if UNITYEDITOR
        UnityEventTools.RemovePersistentListener(_onValueChanged, callback);
#endif
            _onValueChanged.RemoveListener(callback);
        }

        public void RemoveAllListeners()
        {
            if (_onValueChanged == null) return;
#if UNITY_EDITOR
            FieldInfo fieldInfo = typeof(UnityEventBase).GetField("m_PersistentCalls", BindingFlags.Instance | BindingFlags.NonPublic);
            object obj = fieldInfo.GetValue(_onValueChanged);
            obj.GetType().GetMethod("Clear").Invoke(obj, null);
#else
            _onValueChanged.RemoveAllListeners();
#endif
        }

        public void Dispose()
        {
            RemoveAllListeners();
            _onValueChanged = null;
            _value = default;
        }
    }
}