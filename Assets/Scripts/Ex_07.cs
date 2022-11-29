using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_07 : MonoBehaviour
{
    public float num;

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
        reals(num);
    }

}
