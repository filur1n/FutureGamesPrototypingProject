using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CharacterWeapon : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform shootingStartPosition;
    [SerializeField] private Transform shootingFrom;
    public  float force;
    public float fireDelay;

    private float lastTimeShot = 0;

    private void Update()
    {

        Vector3 force = shootingFrom.forward * 1000f;


        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
    }
       void Shoot()
        {
                 if (lastTimeShot + fireDelay < Time.time)
         {
            lastTimeShot = Time.time;
                GameObject newProjectile = Instantiate(projectilePrefab);
                newProjectile.transform.position = shootingStartPosition.position;
            newProjectile.transform.rotation = shootingStartPosition.transform.rotation;
                newProjectile.GetComponent<Projectile>().Initialize(force);
         }
        }
   
}
