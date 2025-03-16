using System.Collections;
using UnityEngine;

public class EnemyShipShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 1f; // Tempo entre disparos
    public float bulletSpeed = 5f;

    void Start()
    {
        StartCoroutine(ShootRepeatedly());
    }

    IEnumerator ShootRepeatedly()
    {
        while (true) 
        {
            Shoot();
            yield return new WaitForSeconds(fireRate);
        }
    }

    void Shoot()
    {
        if (bulletPrefab == null || firePoint == null)
        {
            Debug.LogError("BulletPrefab ou FirePoint não atribuídos!");
            return;
        }

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        
        if (rb != null)
        {
            rb.velocity = Vector2.left * bulletSpeed; // Direção do tiro
        }
    }
}
