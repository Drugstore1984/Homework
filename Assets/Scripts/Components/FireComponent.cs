using UnityEngine;

public class FireComponent : MonoBehaviour,IFireComponent
{
    [SerializeField] EventReceiver fireReceiver;

    public void Fire()
    {
        this.fireReceiver.Call();
    }
}
