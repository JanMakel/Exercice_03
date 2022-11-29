using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_09 : MonoBehaviour
{
    //Variables to store the base and the height
    public int Base;
    public int height;

    //Function that calculates the area of a triangle but only if both number are positive
    private void area(float num1, float num2)
    {
        if(num1 > 0 && num2 > 0)
        {
            Debug.Log($"The area of the triangle is {(num1 * num2) / 2}");
        }
        else
        {
            Debug.Log($"The area of the triangle can not be calculated because the base or the height are negative or 0");
        }
    }

    private void Start()
    {
        //Making the call
        area(Base, height);
    }


}
