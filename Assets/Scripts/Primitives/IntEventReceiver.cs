using Sirenix.OdinInspector;
using System;
using UnityEngine;

public class IntEventReceiver : MonoBehaviour
{
    public event Action<int> OnEvent;

    [Button]
    public void Call(int value)
    {
        this.OnEvent?.Invoke(value);
    }
}
