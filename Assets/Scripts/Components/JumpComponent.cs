using UnityEngine;

public class JumpComponent : MonoBehaviour, IJumpComponent
{
    [SerializeField] Vector3EventReceiver jumpReceiver;
    public void Jump(Vector3 jumpDirection)
    {
       this.jumpReceiver.Call(jumpDirection);
    }
}
