using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_04 : MonoBehaviour
{
    //Variable of the Vector 3 direction, we can change it in the inspector
    public Vector3 initialPos = new Vector3 (1,0,0);

    //Function that moves the object to the direction we put in the variable Vector3
    private void moveRight(Vector3 direction)
    {
        transform.Translate(direction);

    }
    

    private void Update()
    {
        //Making the call, for everytime we press space the object will move
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveRight(initialPos);
        }
    }
}
