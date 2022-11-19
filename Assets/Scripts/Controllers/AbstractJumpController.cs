using UnityEngine;

public abstract class AbstractJumpController : MonoBehaviour
{
    private void Update()
    {
        this.HandleKeyboard();
    }
    private void HandleKeyboard()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.Jump(Vector3.up);
        }
    }
    protected abstract void Jump(Vector3 jumpDirection);
}
