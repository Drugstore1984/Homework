using System;
using Sirenix.OdinInspector;
using UnityEngine;

public class EventReceiver : MonoBehaviour
{
    public event Action OnEvent;

    [Button]
    public void Call()
    {
        this.OnEvent?.Invoke();
    }
}
