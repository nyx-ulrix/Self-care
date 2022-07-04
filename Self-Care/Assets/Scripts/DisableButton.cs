using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableButton : MonoBehaviour
{
    public Button Self;
    private int SelfClickAmount;

    public void disableButton(int BeforeDisable)
    {
        SelfClickAmount++;
        if (SelfClickAmount == BeforeDisable)
        {
            Self.interactable = false;
            SelfClickAmount = 0;    
        } 
    }

}
