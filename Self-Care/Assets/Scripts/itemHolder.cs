using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemHolder : MonoBehaviour
{

    void Start()
    {
        int itemlength = transform.childCount;

        for (int i = 0; i < itemlength; i++)
        {
            GameObject x = transform.GetChild(i).gameObject;

            bool z = false; //PlayerPrefs.GetInt(x.name) == 0 ? false : true;

            if (PlayerPrefs.GetInt(x.name) == 0)
            {
                z = false;
            }
            else
            {
                z = true;
            }

            x.SetActive(z);
        }
    }


}
