using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_04 : MonoBehaviour
{
    public Vector3 initialPos = new Vector3 (1,0,0);
    private void moveRight(Vector3 direction)
    {
        transform.Translate(direction);

    }
    

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveRight(initialPos);
        }
    }
}
