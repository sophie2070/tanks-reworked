using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class TurnManager : MonoBehaviour
{
    private int spelerBeurt = 1;
    public GameObject speler1;
    public GameObject speler2;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] spelers = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject g in spelers)
        {
            if (g.GetComponent<Speler>().spelerNummer == 1)
            {
                speler1 = g;
            }
            else if (g.GetComponent<Speler>().spelerNummer == 2)
            {
                speler2 = g;
            }
        }
        // de speler die aan de beurt is actief maken.
        Invoke("Init", 0.1f);

    }
    void Init()
    {
        if (spelerBeurt == 1)
        {
            Debug.Log("speler1actief");
            // Maak speler 1 actief
            speler1.GetComponent<Speler>().ZetActief(true);
            speler2.GetComponent<Speler>().ZetActief(false);
        }
        else if (spelerBeurt == 2)
        {
            Debug.Log("speler2actief");
            // Maak speler 2 actief
            speler1.GetComponent<Speler>().ZetActief(false);
            speler2.GetComponent<Speler>().ZetActief(true);
        }
    }

    public void WisselBeurt()
    {
        if (spelerBeurt == 1)
        {
            Debug.Log("Speler 2 is aan de beurt");
            spelerBeurt = 2;
            speler1.GetComponent<Speler>().ZetActief(false);
            speler2.GetComponent<Speler>().ZetActief(true);
        }
        else if (spelerBeurt == 2)
        {
            Debug.Log("Speler 1 is aan de beurt");
            spelerBeurt = 1;
            speler1.GetComponent<Speler>().ZetActief(true);
            speler2.GetComponent<Speler>().ZetActief(false);
        }
    }

}
*/