using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_01 : MonoBehaviour
{
    public string letter;
    public bool isItvowel;
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

    private void Update()
    {
        vowel();
    }
}