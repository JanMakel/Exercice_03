using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_02 : MonoBehaviour
{
    
    public int num; //Varible for the number
    public bool isItEven; //Variable for the true or false in the even function

    //Function to know if a number from 0 to 9 if a number it's even or not
    private bool even()
    {
        if (num == 0 || num == 2 || num == 4 || num == 6 || num == 8)
        {
            return isItEven = true;
        }
        else
        {
            return isItEven = false;
        }
    }


    private void Start()
    {
        //Making the call
        even();
        //Then we check if the number it's even because of the true or false in the bool variable we created
        if(isItEven == true)
        {
            Debug.Log($"The number {num} is even");
        }
        else if (isItEven == false)
        {
            Debug.Log($"The number {num} is not even");
        }
    }
}
