using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public Transform bullet;
    public Transform bulletspawnerP;
    public float bulletSpeed;
    void Start()
    {
    }

    void Update()
        //Spawns bullets in the direction of the player facing when pressed left mouse button.
    {
        if (Input.GetMouseButtonDown(0))
        {
            Transform bulletTransform = Instantiate(bullet, bulletspawnerP.position, bulletspawnerP.rotation);
            Rigidbody bulletRB = bulletTransform.GetComponent<Rigidbody>();
            bulletRB.AddRelativeForce(Vector3.forward * bulletSpeed);
        }

    }

}
