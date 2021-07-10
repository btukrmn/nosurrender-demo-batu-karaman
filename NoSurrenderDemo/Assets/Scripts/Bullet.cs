using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletlife = 5f;
    private GameObject CloneBullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Destroy bullet after 5 seconds.
    void LateUpdate()
    {
        CloneBullet = GameObject.Find("Bullet(Clone)");
        Destroy(CloneBullet, bulletlife);
    }

    //Destroy enemy when hit with a bullet.
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
