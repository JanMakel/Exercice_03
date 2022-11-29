using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_02 : MonoBehaviour
{
    public int num;
    public bool isItEven;
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
        even();
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
