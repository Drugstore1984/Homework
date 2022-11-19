using UnityEngine;

public class JumpMechanics : MonoBehaviour
{
    [SerializeField] private Vector3EventReceiver jumpReceiver;
    [SerializeField] private Transform jumpGameobject;
    private void OnEnable()
    {
        this.jumpReceiver.OnEvent += this.OnJump;
    }
    private void OnDisable()
    {
        jumpReceiver.OnEvent -= this.OnJump;
    }
    private void OnJump(Vector3 jumpDirection)
    {
        Rigidbody rb = jumpGameobject.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(jumpDirection,ForceMode.Impulse);
    }
}
