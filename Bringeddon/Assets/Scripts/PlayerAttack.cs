using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] float fireRate;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform meshObj;
    float nextFireTime;
    void Start()
    {
        nextFireTime = Time.time;
    }

    void Update()
    {
    }

    void OnFire()
    {
        if (nextFireTime <= Time.time)
        {
            nextFireTime = Time.time + 1 / fireRate;
            Transform projectile = Instantiate(bulletPrefab, transform.position, Quaternion.identity).transform;
            projectile.forward = meshObj.forward;
        }        
    }
}
