using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialUI : MonoBehaviour
{
    public GameObject GoButton;
    public GameObject NextButton2;
    public GameObject NextButton3;
    public GameObject NextButton4;
    public GameObject NextButton5;
    public GameObject EndButton;

    public GameObject tutorialUI;
    public GameObject tutorialUI_2;
    public GameObject tutorialUI_3;
    public GameObject tutorialUI_4;
    public GameObject tutorialUI_5;

    public GameObject arrowUI;
    public GameObject arrowUI_2;
    public GameObject arrowUI_3;
    public GameObject arrowUI_4;

    public GameObject tutorial_end;

    public void ProceedTutorial()
    {
        GoButton.SetActive(false);
        tutorialUI.SetActive(false);

        NextButton2.SetActive(true);
        tutorialUI_2.SetActive(true);
        arrowUI.SetActive(true);
    }

    public void ProceedTutorial_2()
    {
        NextButton2.SetActive(false);
        tutorialUI_2.SetActive(false);
        arrowUI.SetActive(false);

        NextButton3.SetActive(true);
        tutorialUI_3.SetActive(true);
        arrowUI_2.SetActive(true);
    }

    public void ProceedTutorial_3()
    {
        NextButton3.SetActive(false);
        tutorialUI_3.SetActive(false);
        arrowUI_2.SetActive(false);

        NextButton4.SetActive(true);
        tutorialUI_4.SetActive(true);
        arrowUI_3.SetActive(true);
    }

    public void ProceedTutorial_4()
    {
        NextButton4.SetActive(false);
        tutorialUI_4.SetActive(false);
        arrowUI_3.SetActive(false);

        NextButton5.SetActive(true);
        tutorialUI_5.SetActive(true);
        arrowUI_4.SetActive(true);
    }

    public void ProceedTutorial_5()
    {
        NextButton5.SetActive(false);
        tutorialUI_5.SetActive(false);
        arrowUI_4.SetActive(false);

        EndButton.SetActive(true);
        tutorial_end.SetActive(true);
    }

    public void EndTutorial()
    {
        EndButton.SetActive(false);
        tutorial_end.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        GoButton.SetActive(true);
        tutorialUI.SetActive(true);
    }
}
