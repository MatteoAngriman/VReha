using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivatorScript : MonoBehaviour
{
    public ButtonHandChecker buttonHandChecker;
    public ButtonManager butt;

    private void OnTriggerEnter(Collider other)
    {
        if (buttonHandChecker.isLeftHand)
        {
            Debug.Log("Left Hand Activator");
            Debug.Log("Activated");
            if(buttonHandChecker.exit == true)
                butt.points++;
        } else if (buttonHandChecker.isRightHand)
        {
            Debug.Log("Right Hand Activator");
            Debug.Log("Activated");
            if (buttonHandChecker.exit == true)
                butt.points++;
        }
        
    }
}
