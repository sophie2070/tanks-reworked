using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HEShell : MonoBehaviour
{
    float bulletTtl = 5;
    [SerializeField]
    GameObject HEExplosion;
    [SerializeField]
    Transform spawnpoint;

    
   
    void Update()
    {
        bulletTtl -= Time.deltaTime;
        if (bulletTtl < 0)
        {
            Destroy(gameObject); 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    { 
        FindObjectOfType<AudioManager>().Play("BulletLand");
        //GameObject x = Instantiate(HEExplosion, spawnpoint.position);
        Destroy(gameObject);
    }
}
