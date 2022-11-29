using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_03 : MonoBehaviour
{
    //Varibales for numbers
    public int numero1;
    public int numero2;

    //Function to know if a division it's exact with a module
    private void exactDiv( int num1, int num2)
    {

        if (num1 % num2 == 0)
        {
            Debug.Log($"The division of {num1} / {num2} is exact");
        }
        else
        {
            Debug.Log($"The division of {num1} / {num2} is not exact");
        }
    }

    private void Start()
    {
        //Making the call of the function
        exactDiv(numero1, numero2);
    }
}
