using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillDetection : MonoBehaviour
{
    [SerializeField]
    GameObject killscreen;
    void OnCollisionEnter2D(Collision2D killed)
    {
        if (killed.gameObject.tag == "bullet")
        {
            FindObjectOfType<AudioManager>().Play("killed");
            killscreen.SetActive(true);
            Debug.Log("hit");
        }
    }
}
