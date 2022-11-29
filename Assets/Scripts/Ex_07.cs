using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_07 : MonoBehaviour
{
    //Varible num for the number
    public float num;

    //Function that returns always the absolute value of a number, eather negative or positive
    private void reals(float absolute)
    {
        if(absolute > 0)
        {
            Debug.Log($"{absolute * 1}");
        }
        else if(absolute < 0)
        {
            Debug.Log($"{absolute * -1}");
        }

    }
    private void Start()
    {
        //Making the call
        reals(num);
    }

}
