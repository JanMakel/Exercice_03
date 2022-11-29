using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_08 : MonoBehaviour
{
    //Variable of the year
    public int leap;
    
    //Funciton that checks if a year it's a leap year or not, returns a true or false in each case
    private bool year(int years)
    {
        if (years % 4 == 0 && years % 100 > 0 || years % 400 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Start()
    {
        //Making the call
        year(leap);
        //Then we check if the function is true or false, to distern in the console the results
        if(year(leap) == true)
        {
            Debug.Log($"The year {leap} it's a leap year");
        }
        else
        {
            Debug.Log($"The year {leap} it's not a leap year");
        }
    }
}
