using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Actions : MonoBehaviour
{
    public Happiness HappyBar;
    public Motivation MotiveBar;
    public Fatigue FatigueBar;
    public float FatigueDemeritHappy;
    public float FatigueDemeritMotive;
    public GameObject LoseNotification;
    public GameObject WinNotification;

    public GameObject AnimAction; // initialize game object to be editable from inspector (not necessarily important to fill in)
    public GameObject Character; // initialize original character into inspector

    void Start()
    {
        AnimAction.SetActive(false); // animation should not start, hence false
        Character.SetActive(true); // original character to appear at all times when idle, hence true
    }

    private void Update()
    {
        if ((PlayerPrefs.GetFloat("Happiness")) <= 0 && (PlayerPrefs.GetFloat("Motivation")) <= 0)
        {
            LoseNotification.SetActive(true);
        }
    }

    public void ButtonPress()
    {
        // on button press, the character would play the action selected
        AnimAction.SetActive(true);
        Character.SetActive(false); // hide the original character model
        Invoke("EndAnimation", 5f); // invoke animation, play for 5 seconds
            
    }

    void EndAnimation()
    {
        // after 5 seconds, the animation would end and the original chracter model would show
        AnimAction.SetActive(false);
        Character.SetActive(true);
    }

    //adds happiness points based on what is put in the inspector
    public void ModifyHappiness(float happiness)
    {
        // Checks if its adding happiness 
        if ((happiness > 0) == true)                                                
        {
            //the if else statement is used to make sure that the value  does not go past 100
            if (PlayerPrefs.GetFloat("Happiness") + happiness <= 100)
            {
                PlayerPrefs.SetFloat("Happiness", ((PlayerPrefs.GetFloat("Happiness") + happiness) * PlayerPrefs.GetFloat("HappyMultiplier")));
                HappyBar.SetHappy(PlayerPrefs.GetFloat("Happiness"));
            }

            else if (PlayerPrefs.GetFloat("Happiness") + happiness > 100)
            {
                PlayerPrefs.SetFloat("Happiness", 100);
                HappyBar.SetHappy(PlayerPrefs.GetFloat("Happiness"));
            }

        }

        //checks if happiness is being deducted
        else if ((happiness < 0) == true)
        {
            if ((PlayerPrefs.GetFloat("Happiness") + happiness) >= 0)
            {
                PlayerPrefs.SetFloat("Happiness", (PlayerPrefs.GetFloat("Happiness") + happiness));
                HappyBar.SetHappy(PlayerPrefs.GetFloat("Happiness"));
            }
            else if ((PlayerPrefs.GetFloat("Happiness") + happiness) < 0)
            {
                PlayerPrefs.SetFloat("Happiness", 0);
                HappyBar.SetHappy(PlayerPrefs.GetFloat("Happiness"));
            }

        }

    }

    //adds motivation points based on what is put in the inspector
    public void ModifyMotivation(float motivation)
    {
        //checks if the motivation is being added
        if ((motivation > 0) == true)
        {
            //if else statement used to limit the motivation so that it doesnt go past 100
            if (PlayerPrefs.GetFloat("Motivation") + motivation <= 100)
            {
                PlayerPrefs.SetFloat("Motivation", ((PlayerPrefs.GetFloat("Motivation") + motivation) * PlayerPrefs.GetFloat("MotiveMultiplier")));
                MotiveBar.SetMotivation(PlayerPrefs.GetFloat("Motivation"));
            }

            else if (PlayerPrefs.GetFloat("Motivation") + motivation > 100)
            {
                PlayerPrefs.SetFloat("Motivation", 100);
                MotiveBar.SetMotivation(PlayerPrefs.GetFloat("Motivation"));
            }

        }

        //checks if the motivation is being deducted
        else if ((motivation < 0) == true)
        {
            //ensures that the motivation value does not go below 0
            if ((PlayerPrefs.GetFloat("Motivation") + motivation) >= 0)
            {
                PlayerPrefs.SetFloat("Motivation", (PlayerPrefs.GetFloat("Motivation") + motivation));
                MotiveBar.SetMotivation(PlayerPrefs.GetFloat("Motivation"));
            }
            else if ((PlayerPrefs.GetFloat("Motivation") + motivation) < 0)
            {
                PlayerPrefs.SetFloat("Motivation", 0);
                MotiveBar.SetMotivation(PlayerPrefs.GetFloat("Motivation"));
            }

        }

    }

    public void ModifyFatigue(float fatigue)
    {
        //checks if the fatigue is being added
        if ((fatigue > 0) == true)
        {
            //if else statement used to limit the fatigue so that it doesnt go past 100
            if (PlayerPrefs.GetFloat("Fatigue") + fatigue <= 100)
            {
                PlayerPrefs.SetFloat("Fatigue", ((PlayerPrefs.GetFloat("Fatigue") + fatigue)));
                FatigueBar.SetFatigue(PlayerPrefs.GetFloat("Fatigue"));
            }

            else if (PlayerPrefs.GetFloat("Fatigue") + fatigue > 100)
            {
                PlayerPrefs.SetFloat("Fatigue", 100);
                FatigueBar.SetFatigue(PlayerPrefs.GetFloat("Fatigue"));
            }

        }

        //checks if the fatigue is being deducted
        else if ((fatigue < 0) == true)
        {
            //ensures that the fatigue value does not go below 0
            if ((PlayerPrefs.GetFloat("Fatigue") + fatigue) >= 0)
            {
                PlayerPrefs.SetFloat("Fatigue", (PlayerPrefs.GetFloat("Fatigue") + fatigue));
                FatigueBar.SetFatigue(PlayerPrefs.GetFloat("Fatigue"));
            }
            else if ((PlayerPrefs.GetFloat("Fatigue") + fatigue) < 0)
            {
                PlayerPrefs.SetFloat("Fatigue", 0);
                FatigueBar.SetFatigue(PlayerPrefs.GetFloat("Fatigue"));
            }

        }

    }
    //code to reset entire motivation value to 25 
    public void ResetMotivation(float motivation)
    {
        PlayerPrefs.SetFloat("Motivation", 25);
        MotiveBar.SetMotivation(PlayerPrefs.GetFloat("Motivation"));
    }

    //code to reset entire happiness value to 25 
    public void ResetHappiness(float happiness)
    {
        PlayerPrefs.SetFloat("Happiness", 25);
        HappyBar.SetHappy(PlayerPrefs.GetFloat("Happiness"));
    }

    //motivation mulitplier
    public void MotiveMultiplier(float motive)
    {
        PlayerPrefs.SetFloat("MotiveMultiplier", (PlayerPrefs.GetFloat("MotiveMultiplier") + motive));
    }

    //happiness multiplier
    public void HappyMultiplier(float motive)
    {
        PlayerPrefs.SetFloat("HappyMultiplier", (PlayerPrefs.GetFloat("HappyMultiplier") + motive));
    }

    //reset motivation
    public void ResetMotiveMultiplier(float motive)
    {
        PlayerPrefs.SetFloat("MotiveMultiplier", 1);
    }

    //reset happiness
    public void ResetHappyMultiplier(float motive)
    {
        PlayerPrefs.SetFloat("HappyMultiplier", 1);
    }

    public void FatigueDemerit(float fatigueMin)
    {
        if((PlayerPrefs.GetFloat("Fatigue")) > fatigueMin)
        {
            PlayerPrefs.SetFloat("Happiness", (PlayerPrefs.GetFloat("Happiness") - FatigueDemeritHappy));
            HappyBar.SetHappy(PlayerPrefs.GetFloat("Happiness"));

            PlayerPrefs.SetFloat("Motivation", (PlayerPrefs.GetFloat("Motivation") - FatigueDemeritMotive));
            MotiveBar.SetMotivation(PlayerPrefs.GetFloat("Motivation"));

        }
    }
}
