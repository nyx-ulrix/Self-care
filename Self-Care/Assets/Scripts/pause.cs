using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject pausePopup;


    public void openMenu()
    {
        pausePopup.SetActive(true);
    }

    public void closeMenu()
    {
        pausePopup.SetActive(false);
    }
}
