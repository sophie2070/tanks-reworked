using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class TankControl2 : MonoBehaviour
{
    [SerializeField]
    Transform barrelRotator;
    [SerializeField]
    Transform firePoint;
    [SerializeField]
    GameObject killscreen;

    [SerializeField]
    GameObject heShell;
    [SerializeField]
    GameObject apShell;
    [SerializeField]
    GameObject poolShot;
    [SerializeField]
    GameObject nuke;

    private float pivotSpeed = 3;
    private float movementSpeed = 5;
    public float shootingForce = 10;
    public int shellSelected;
    public Turn turn;
    public int movementType = -1;

    public void SetPower(float firepower)
    {
        shootingForce = firepower;
    }
    public void shellToFire(int shellSelected)
    {
            switch (shellSelected)
            {
                case 1:
                if (Input.GetKeyDown(KeyCode.B))
                {
                    Instantiate(heShell, firePoint.position, firePoint.rotation).GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * shootingForce, ForceMode2D.Impulse);

                    turn.PlayerTurn = true;
                }
                    break;

                case 2:
                if (Input.GetKeyDown(KeyCode.B))
                {
                    Instantiate(apShell, firePoint.position, firePoint.rotation).GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * shootingForce, ForceMode2D.Impulse);

                    turn.PlayerTurn = true;
                }
                    break;

                case 3:
                if (Input.GetKeyDown(KeyCode.B))
                {
                    Instantiate(poolShot, firePoint.position, firePoint.rotation).GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * shootingForce, ForceMode2D.Impulse);

                    turn.PlayerTurn = true;
                }
                    break;

                case 4:
                if (Input.GetKeyDown(KeyCode.B))
                {
                    Instantiate(nuke, firePoint.position, firePoint.rotation).GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * shootingForce, ForceMode2D.Impulse);

                    turn.PlayerTurn = true;
                }
                    break;

                default:
                    shellSelected = 1;
                    break;
            }
        Debug.Log(shellSelected);
    }

    void Update()
    {
        if (turn.PlayerTurn == false)
        {      
            barrelRotator.RotateAround(Vector3.forward, Input.GetAxis("Vertical") * pivotSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
                movementType = 1;
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                movementType = -1;
            }

                if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
                movementType = 1;
            }
            if (Input.GetKey(KeyCode.A))
            {
                movementType = -1;
            }
        }
    }
}