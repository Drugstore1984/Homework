using UnityEngine;

public class MoveComponent : MonoBehaviour, IMoveComponent
{
    [SerializeField] Vector3EventReceiver moveReceiver;
    public void Move(Vector3 vector)
    {
        this.moveReceiver.Call(vector);
    }
}
