using System;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] MonoBehaviour[] components;

    public T Get<T>()
    {
        for (int i = 0; i < this.components.Length; i++)
        {
            if (components[i] is T result)
                return result;
        }
        throw new Exception($"Component type of {typeof(T).Name} not found!");
    }
    public bool TryGet<T>(out T result)
    {
        for (int i = 0; i < this.components.Length; i++)
        {
            if (components[i] is T tComponent)
            {
                result = tComponent;
                return true;
            }
        }
        result = default(T);
        return false;
    }
}
