using Sirenix.OdinInspector;
using System;
using UnityEngine;

public class Vector3EventReceiver : MonoBehaviour
{
    public event Action<Vector3> OnEvent;

    [Button]
    public void Call(Vector3 value)
    {
        this.OnEvent?.Invoke(value);
    }
}
