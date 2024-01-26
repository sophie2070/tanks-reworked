using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class TankControl : MonoBehaviour
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
    int ShellSelected;

    public Animator anim;
    public void SetPower(float firepower)
    {
        shootingForce = firepower;
    }

    public void shelltofiretwo(int shellSelected)
    {
        ShellSelected = shellSelected;
    }

    void shellToFire(int shellSelected)
    {
        switch (shellSelected)
        {
            case 1:

                Instantiate(heShell, firePoint.position, firePoint.rotation).GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * shootingForce, ForceMode2D.Impulse);
                FindObjectOfType<AudioManager>().Play("BulletShot");
                turn.PlayerTurn = false;

                break;

            case 2:

                Instantiate(apShell, firePoint.position, firePoint.rotation).GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * shootingForce, ForceMode2D.Impulse);
                FindObjectOfType<AudioManager>().Play("BulletShot");
                turn.PlayerTurn = false;

                break;

            case 3:

                Instantiate(poolShot, firePoint.position, firePoint.rotation).GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * shootingForce, ForceMode2D.Impulse);
                FindObjectOfType<AudioManager>().Play("BulletShot");
                turn.PlayerTurn = false;

                break;

            case 4:

                Instantiate(nuke, firePoint.position, firePoint.rotation).GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * shootingForce, ForceMode2D.Impulse);
                FindObjectOfType<AudioManager>().Play("NukeFall");
                turn.PlayerTurn = false;

                break;

            default:
                shellSelected = 1;
                break;
        }
    }

    void Update()
    {

        if (turn.PlayerTurn == true)
        {
            barrelRotator.RotateAround(Vector3.forward, Input.GetAxis("Vertical") * pivotSpeed * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                shellToFire(ShellSelected);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
                anim.SetBool("moving", true);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                anim.SetBool("moving", false); 
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
                anim.SetBool("moving", true);
            }
            if (Input.GetKey(KeyCode.A))
            {
                anim.SetBool("moving", false);
            }
        }
    }
}