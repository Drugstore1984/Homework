using UnityEngine;

public class ShootBulletEngine : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawnPosition;
    [SerializeField] private float bulletFireForce = 10f;

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPosition.position, bulletSpawnPosition.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(bulletSpawnPosition.forward * bulletFireForce, ForceMode.Impulse);
    }
}
