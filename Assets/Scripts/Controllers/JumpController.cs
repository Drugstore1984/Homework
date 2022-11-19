using UnityEngine;

public class JumpController : AbstractJumpController
{
    [SerializeField] private Entity unit;
    private IJumpComponent jumpComponent;
    private void Awake()
    {
        this.jumpComponent = this.unit.Get<IJumpComponent>();
    }
    protected override void Jump(Vector3 jumpDirection)
    {
        const float jumpForce = 5.0f;
        var velocity = jumpDirection * jumpForce;
        this.jumpComponent.Jump(velocity);
    }
}
