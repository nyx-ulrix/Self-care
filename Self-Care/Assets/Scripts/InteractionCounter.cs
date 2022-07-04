using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionCounter : MonoBehaviour
{
    public int clickAmount = 0;
    public int ResetCount;
    public Button ControlledButton;
    public Button Counter;


    private void Start()
    {
        Counter.onClick.AddListener(() => buttonClick(12));
    }

    public void buttonClick(int clickedTimes)
    {
        clickAmount++;

        if (clickAmount == ResetCount)
        {
            ControlledButton.interactable = true;
            clickAmount = 0;
        }
    }

   
}
