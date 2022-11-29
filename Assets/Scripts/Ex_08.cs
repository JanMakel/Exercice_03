using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_08 : MonoBehaviour
{
    public int leap;
    
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
        year(leap);

        if(year = true)
        {
            Debug.Log($"The year {leap} it's a leap year");
        }
        else if (year = false)
        {
            Debug.Log($"The year {leap} it's not a leap year");
        }
    }
}
