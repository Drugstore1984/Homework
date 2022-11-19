using UnityEngine;

public abstract class AbstractFireController : MonoBehaviour
{
    private void Update()
    {
        this.HandleMouse();
    }
    private void HandleMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.Fire();
        }
    }
    protected abstract void Fire();
}
