using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionOpen : MonoBehaviour
{
    // Start is called before the first frame update

    string[] buttonConnections = new string[] {
        "Play Computer:item1",
        "Cycle:item2"
        //,"buttonNamee:itemName"
    };

    public void UpdateButtons()
    {
        GameObject buttons = transform.GetChild(0).GetChild(0).gameObject;

        for (int x = 0; x < buttonConnections.Length; x++)
        {
            for (int i = 0; i < buttons.transform.childCount; i++)
            {
                GameObject button = buttons.transform.GetChild(i).gameObject;
                string buttonName = buttonConnections[x].Split(':')[0];
                string itemName = buttonConnections[x].Split(':')[1];

                if (buttonName == button.name)
                {
                    bool xyz = PlayerPrefs.GetInt(itemName) == 0 ? false : true;

                    button.SetActive(xyz);
                }
            }
        }
    }
}
