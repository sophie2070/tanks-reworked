using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolShot : MonoBehaviour
{
    float bulletTtl = 3f;
    
    void Update()
    {
        bulletTtl -= Time.deltaTime;
        if (bulletTtl < 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<AudioManager>().Play("ricochet");
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
