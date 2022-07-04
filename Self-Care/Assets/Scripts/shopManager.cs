using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class shopManager : MonoBehaviour
{
    public Text coinsTxt;
    public Button item;
    public GameObject Notification;
    public Text NotificationText;
    public string ItemName;
    public GameObject itemDisplay;
    public Actions Action;
    public float HappyGain;


    // Start is called before the first frame update
    void Start()
    {

        coinsTxt.text = "Money: $" + PlayerPrefs.GetFloat("money");

    }
    void disablebtn()
    {
        item.interactable = false;
    }



    public void Buy(float price)
    {
        if (PlayerPrefs.GetFloat("money") >= price)
        {
            PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") - price);
            coinsTxt.text = "Money: $" + PlayerPrefs.GetFloat("money");
            Notification.SetActive(true);
            NotificationText.text = ("You have successfully purchased " + ItemName);
            //bool x = PlayerPrefs.GetInt("itemCheck") == 0 ? false : true;        
            PlayerPrefs.SetInt(itemDisplay.name, 1);
            itemDisplay.SetActive(true);
            //item.onClick.AddListener(disablebtn);
            disablebtn();
            Action.ModifyHappiness(HappyGain);
        }
        else if (PlayerPrefs.GetFloat("money") < price)
        {
            Notification.SetActive(true);
            NotificationText.text = ("You need $" + (price -(PlayerPrefs.GetFloat("money"))) + (" more to buy ") + ItemName);
        }
    }
}
