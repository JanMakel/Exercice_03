using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_06 : MonoBehaviour
{
    //Variables to check
    public int num1;
    public int num2;

    //Function that checks if two numbers are larger, smaller or equal
    private void larger(int nim1, int nim2)
    {
        if(nim1 > nim2)
        {
            Debug.Log($"{nim1} it's larger than {nim2}");
        }
        else if (nim1 < nim2)
        {
            Debug.Log($"{nim2} it's larger than {nim1}");
        }
        else if (nim1 == nim2)
        {
            Debug.Log($"{nim1} it's equal to {nim2}");
        }
    }

    private void Start()
    {
        //Making the call of the function
        larger(num1, num2);
    }


}
