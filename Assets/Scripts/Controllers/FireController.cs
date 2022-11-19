using UnityEngine;

public class FireController : AbstractFireController
{
    [SerializeField] private Entity unit;
    private IFireComponent fireComponent;
    private void Awake()
    {
        this.fireComponent = this.unit.Get<IFireComponent>();
    }
    protected override void Fire()
    {
        this.fireComponent.Fire();
    }
}
