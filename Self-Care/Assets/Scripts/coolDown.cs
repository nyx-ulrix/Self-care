using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coolDown : MonoBehaviour
{
    public Button mainRoutine;
    public Button sideRoutine1;
    public Button sideRoutine2;
    public float cooldownTimeMain = 2f;

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(cooldownTimeMain);
        mainRoutine.interactable = true;
        sideRoutine1.interactable = true;
        sideRoutine2.interactable = true;
    }
    // Update is called once per frame
    void Update()
    {
        mainRoutine.onClick.AddListener(buttonClicked);

        if(mainRoutine.interactable == false && sideRoutine1.interactable == false && sideRoutine2.interactable == false)
        {
            StartCoroutine(Delay());
        }
        
    }
    void buttonClicked()
    {
        mainRoutine.interactable = false;
        sideRoutine1.interactable = false;
        sideRoutine2.interactable = false;
      
    }

}
