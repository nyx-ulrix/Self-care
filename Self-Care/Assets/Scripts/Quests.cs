using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quests : MonoBehaviour
{
    public float MinHappy;
    public float MinMotive;
    public float MaxFatigue;
    public float FatigueGain;
    public float HappyGain;
    public float MotiveGain;
    public float timeCheck;
    public Text coinsTxt;
    public GameObject Notification;
    public Text NotificationText;
    public Actions Action;
    public GameObject WinNotification;


    public void Quest(float pay)
    {
        if (PlayerPrefs.GetFloat("Happiness") >= MinHappy && PlayerPrefs.GetFloat("Motivation") >= MinMotive && PlayerPrefs.GetFloat("Fatigue") <= MaxFatigue)
        {
            Notification.SetActive(true);
            PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") + pay);
            coinsTxt.text = "Money: $" + PlayerPrefs.GetFloat("money");
            NotificationText.text = ("Congratulations yous have earned $" + pay);
            Action.ModifyFatigue(FatigueGain);
            Action.ModifyHappiness(HappyGain);
            Action.ModifyMotivation(MotiveGain);
        }

        else
        {
            if (PlayerPrefs.GetFloat("Happiness") < MinHappy && PlayerPrefs.GetFloat("Motivation") < MinMotive)
            {
                Notification.SetActive(true);
                NotificationText.text = ("sorry not enough motivation and happiness and youre tired please rest:(");

            }

            else if (PlayerPrefs.GetFloat("Happiness") < MinHappy)
            {
                Notification.SetActive(true);
                NotificationText.text = ("sorry not enough Happiness :(");

            }

            else if (PlayerPrefs.GetFloat("Motivation") < MinMotive)
            {
                Notification.SetActive(true);
                NotificationText.text = ("sorry not enough Motivation :(");

            }

            else if (PlayerPrefs.GetFloat("Fatigue") > MaxFatigue)
            {
                Notification.SetActive(true);
                NotificationText.text = ("Youre too tired please rest :(");
            }
        }
    }

    public void Win()
    {
        if (PlayerPrefs.GetFloat("Happiness") >= MinHappy && PlayerPrefs.GetFloat("Motivation") >= MinMotive && PlayerPrefs.GetFloat("Fatigue") <= MaxFatigue)
        {
            WinNotification.SetActive(true);
        }

        else
        {
            if (PlayerPrefs.GetFloat("Happiness") < MinHappy && PlayerPrefs.GetFloat("Motivation") < MinMotive)
            {
                Notification.SetActive(true);
                NotificationText.text = ("sorry not enough motivation and happiness and youre tired please rest:(");

            }

            else if (PlayerPrefs.GetFloat("Happiness") < MinHappy)
            {
                Notification.SetActive(true);
                NotificationText.text = ("sorry not enough Happiness :(");

            }

            else if (PlayerPrefs.GetFloat("Motivation") < MinMotive)
            {
                Notification.SetActive(true);
                NotificationText.text = ("sorry not enough Motivation :(");

            }

            else if (PlayerPrefs.GetFloat("Fatigue") > MaxFatigue)
            {
                Notification.SetActive(true);
                NotificationText.text = ("Youre too tired please rest :(");
            }
        }
    }
    public void QuestMessage()
    {
        if (PlayerPrefs.GetFloat("Happiness") < MinHappy && PlayerPrefs.GetFloat("Motivation") < MinMotive && PlayerPrefs.GetFloat("Fatigue") > MaxFatigue)
        {
            Notification.SetActive(true);
            NotificationText.text = ("sorry not enough motivation and happiness :(");

        }

        else if (PlayerPrefs.GetFloat("Happiness") < MinHappy)
        {
            Notification.SetActive(true);
            NotificationText.text = ("sorry not enough Happiness :(");

        }

        else if (PlayerPrefs.GetFloat("Motivation") < MinMotive)
        {
            Notification.SetActive(true);
            NotificationText.text = ("sorry not enough Motivation :(");

        }

        else if (PlayerPrefs.GetFloat("Fatigue") > MaxFatigue)
        {
            Notification.SetActive(true);
            NotificationText.text = ("take a break have a kit kat (not sponsored) :(");

        }
    }
}

