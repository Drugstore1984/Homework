using UnityEngine;

public class MoveMechanics : MonoBehaviour
{
    [SerializeField] Vector3EventReceiver vector3EventReceiver;
    [SerializeField] Transform moveGameobject;

    private void OnEnable()
    {
        this.vector3EventReceiver.OnEvent += this.OnMove;       
    }
    private void OnDisable()
    {
        this.vector3EventReceiver.OnEvent -= this.OnMove;
    }

    private void OnMove(Vector3 direction)
    {
        this.moveGameobject.position += direction;
    }
}
