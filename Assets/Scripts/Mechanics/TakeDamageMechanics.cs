using UnityEngine;

public class TakeDamageMechanics : MonoBehaviour
{
    [SerializeField] private IntBehaviour hitPoints;
    [SerializeField] private IntEventReceiver takeDamageReceiver;

    private void OnEnable()
    {
        this.takeDamageReceiver.OnEvent += this.OnDamageTaken;
    }
    private void OnDisable()
    {
        this.takeDamageReceiver.OnEvent -= this.OnDamageTaken;
    }

    private void OnDamageTaken( int damage)
    {
        this.hitPoints.Value -= damage;
    }
}
