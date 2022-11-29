using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_05 : MonoBehaviour
{
    //Varibale for the number we are going to use
    public int mult;

    //Making a function to calculate the table
    private void calculator(int num)
    {
        Debug.Log($"{num} x 1 = {num * 1}");
        Debug.Log($"{num} x 2 = {num * 2}");
        Debug.Log($"{num} x 3 = {num * 3}");
        Debug.Log($"{num} x 4 = {num * 4}");
        Debug.Log($"{num} x 5 = {num * 5}");
        Debug.Log($"{num} x 6 = {num * 6}");
        Debug.Log($"{num} x 7 = {num * 7}");
        Debug.Log($"{num} x 8 = {num * 8}");
        Debug.Log($"{num} x 9 = {num * 9}");
        Debug.Log($"{num} x 10 = {num * 10}");
    }

    private void Start()
    {
        //Making the call
        calculator(mult);

    }

}
