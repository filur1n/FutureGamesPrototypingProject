using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CharacterWeapon : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform shootingStartPosition;
    [SerializeField] private Transform shootingFrom;
    private Vector3 force;

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

            GameObject newProjectile = Instantiate(projectilePrefab);
            newProjectile.transform.position = shootingStartPosition.position;
            newProjectile.GetComponent<Projectile>().Initialize(force);
        }
   
}
