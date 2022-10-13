using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TankControl2 : MonoBehaviour
{
    [SerializeField]
    Transform barrelRotator;
    [SerializeField]
    GameObject bulletToFire;
    [SerializeField]
    Transform firePoint;
     
    
    private float pivotSpeed = 3;
    private float movementSpeed = 5;
    public float shootingForce = 10;
    public Turn turn;



    public void SetPower(float firepower)
    {
        shootingForce = firepower;
    }
    void Update()
    {
        if(turn.PlayerTurn == false)

        {
            barrelRotator.RotateAround(Vector3.forward, Input.GetAxis("Vertical") * pivotSpeed * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.B))
            {
                GameObject b = Instantiate(bulletToFire, firePoint.position, firePoint.rotation);
                b.GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * shootingForce, ForceMode2D.Impulse);

                
                    turn.PlayerTurn = true;
                
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
            }
        }
    }
}