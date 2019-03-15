using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivatorScript : MonoBehaviour
{
    public ButtonHandChecker buttonHandChecker;


    private void OnTriggerEnter(Collider other)
    {
        if (buttonHandChecker.isLeftHand)
        {
            Debug.Log("Left Hand Activator");
            Debug.Log("Activated");
        } else if (buttonHandChecker.isRightHand)
        {
            Debug.Log("Right Hand Activator");
            Debug.Log("Activated");
        }
        
    }
}
