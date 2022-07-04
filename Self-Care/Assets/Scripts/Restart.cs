using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject Notification;
    public GameObject CLoseNotification;
    public Text coinsTxt;
    public Happiness HappyBar;
    public Motivation MotiveBar;
    public Fatigue FatigueBar;
    public GameObject Computer;
    public GameObject Bycicle;
    public GameObject Hat;

    public void NewGame()
    {
        SceneManager.LoadScene("main");
        PlayerPrefs.SetFloat("Happiness", 25);
        HappyBar.SetHappy(PlayerPrefs.GetFloat("Happiness"));
        PlayerPrefs.SetFloat("Motivation", 25);
        MotiveBar.SetMotivation(PlayerPrefs.GetFloat("Motivation"));
        PlayerPrefs.SetFloat("Fatigue", 0);
        FatigueBar.SetFatigue(PlayerPrefs.GetFloat("Fatigue"));
        PlayerPrefs.SetFloat("money", 0);
        PlayerPrefs.SetFloat("HappyMultiplier", 1);
        PlayerPrefs.SetFloat("MotiveMultiplier", 1);
        PlayerPrefs.SetInt(Bycicle.name, 0);
        Bycicle.SetActive(false); 
        PlayerPrefs.SetInt(Computer.name, 0);
        Computer.SetActive(false); 
        PlayerPrefs.SetInt(Hat.name, 0);
        Hat.SetActive(false);
        coinsTxt.text = "Money: $" + PlayerPrefs.GetFloat("money");
        Notification.SetActive(!enabled);
        CLoseNotification.SetActive(!enabled);
    }
}
