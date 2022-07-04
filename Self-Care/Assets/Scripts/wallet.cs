using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wallet : MonoBehaviour
{
    public Text coinsTxt;
    // Start is called before the first frame update
    void Start()
    {
        coinsTxt.text = "Money: $" + PlayerPrefs.GetFloat("money");
    }


}
