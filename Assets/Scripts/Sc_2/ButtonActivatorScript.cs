using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivatorScript : MonoBehaviour
{
    public ButtonHandChecker buttonHandChecker;
    public ButtonManager butt;
    public ButtonHandChecker checker;
    public bool deactivated = true;   // al posto di "exit", per controllare quando il pulsante non è più premuto

    private void OnTriggerEnter(Collider other)
    {
        if (buttonHandChecker.isLeftHand && butt.hand ==0)
        {
            Debug.Log("Left Hand Activator");
            Debug.Log("Activated");
            deactivated = false;
            //if(buttonHandChecker.exit == true)
                butt.points++;
        } else if (buttonHandChecker.isRightHand && butt.hand ==1)
        {
            Debug.Log("Right Hand Activator");
            Debug.Log("Activated");
            deactivated = false;
            //if (buttonHandChecker.exit == true)
                butt.points++;
        }

    }
    public void OnTriggerExit(Collider other)
    {
        deactivated = true;
    }

    private void Start()
    {
        var b = GameObject.Find("halfHola(Clone)");
        butt = b.GetComponent<ButtonManager>();
    }
}
