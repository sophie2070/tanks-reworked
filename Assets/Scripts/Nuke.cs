using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuke : MonoBehaviour
{
    float bulletTtl = 5;

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
        FindObjectOfType<AudioManager>().Play("NukeLand");
        Destroy(gameObject);
    }
}
