using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillDetection : MonoBehaviour
{
    [SerializeField]
    GameObject deathpanel;
    [SerializeField]
    GameObject normalui;
    void OnCollisionEnter2D(Collision2D killed)
    {
        if (killed.gameObject.tag == "bullet")
        {
            FindObjectOfType<AudioManager>().Play("killed");
            deathpanel.SetActive(!deathpanel.activeSelf);
            normalui.SetActive(!normalui.activeSelf);
        }
    }
}
