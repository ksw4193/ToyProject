using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    private Coroutine firingCoroutine;
    private float fireRate = 0.1f;
    public void Startfiring()
    {
        if (firingCoroutine == null)
            firingCoroutine = StartCoroutine(FireRoutine());
    }

    public void StopFiring()
    {
        if (firingCoroutine != null)
        {
            StopCoroutine(firingCoroutine);
            firingCoroutine = null;
        }
    }

    IEnumerator FireRoutine()
    {
        while (true)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
                rb.AddForce(firePoint.forward * 100, ForceMode.VelocityChange);
            yield return new WaitForSeconds(fireRate);
        }
    }
}
