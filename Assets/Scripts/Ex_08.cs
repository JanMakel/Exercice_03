using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_08 : MonoBehaviour
{
    public int leap;
    public bool years2;
    private bool year(int years)
    {
        if (years % 4 == 0 && years % 100 > 0 || years % 400 == 0)
        {
            return years2 == true;
        }
        else
        {
            return years2 == false;
        }
    }

    private void Start()
    {
        year(leap);

        if(years2 == true)
        {
            Debug.Log($"The year {leap} it's a leap year");
        }
        else if (years2 == false)
        {
            Debug.Log($"The year {leap} it's not a leap year");
        }
    }
}
