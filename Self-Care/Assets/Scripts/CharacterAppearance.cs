using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAppearance : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void FixedUpdate()
    {
        animator.SetFloat("Motivation", PlayerPrefs.GetFloat("Motivation"));
        animator.SetFloat("Happiness", PlayerPrefs.GetFloat("Happiness"));
    }
}
