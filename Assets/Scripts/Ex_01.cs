using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_01 : MonoBehaviour
{
    //Variables
    public string letter;
    public bool isItvowel;

    //Function to distern a vowel from a consonant letter
    private bool vowel()
    {
        if (letter == "a" || letter == "e" || letter == "o" || letter == "i" || letter == "u")
        {
            return isItvowel = true;
        }
        else
        {
            return  isItvowel = false;
        }
    }

    //I've putted the update just to the function works also in the play mode
    private void Update()
    {
        vowel();
    }
}