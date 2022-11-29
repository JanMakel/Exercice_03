using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_10 : MonoBehaviour
{
    //Function that makes an object bigger in x, y, and z.
    private void scale()
    {
        transform.localScale += Vector3.one;
    }

    private void Update()
    {
        //Making the call of the function only when you press left click on the mouse
        if (Input.GetMouseButtonDown(0))
        {
            scale();
        }
    }
}
