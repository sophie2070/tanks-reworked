using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellSelect : MonoBehaviour
{
    [SerializeField]
    GameObject heShell;
    [SerializeField]
    GameObject apShell;
    [SerializeField]
    GameObject poolShot;
    [SerializeField]
    GameObject nuke;


    public int shellSelected;
    public void shellToFire(int shellSelected)
    {
        switch (shellSelected)
        {
            case 1:

                break;

            case 2:

                break;

            case 3:

                break;

            case 4:

                break;

            default:
                shellSelected = 1;
                break;

        }
        Debug.Log(shellSelected);
    }
}
