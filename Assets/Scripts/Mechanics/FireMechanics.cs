using UnityEngine;

public class FireMechanics : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform bulletSpawnPosition;
    [SerializeField] float bulletFireForce = 10f;
    [SerializeField] EventReceiver fireReceiver;

    private void OnEnable()
    {
        this.fireReceiver.OnEvent += this.OnFire;
    }

    private void OnDisable()
    {
        this.fireReceiver.OnEvent -= this.OnFire;
    }

    private void OnFire()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPosition.position,bulletSpawnPosition.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(bulletSpawnPosition.forward * bulletFireForce, ForceMode.Impulse);
    }
}
