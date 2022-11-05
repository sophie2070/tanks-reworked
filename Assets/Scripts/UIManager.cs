using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    GameObject deathpanel;
    [SerializeField]
    GameObject normalui;

    void ToggleUIPanel()
    {
        deathpanel.SetActive(!deathpanel.activeSelf);
        normalui.SetActive(!normalui.activeSelf);
    }
}
