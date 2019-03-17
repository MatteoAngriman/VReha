using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandChecker : MonoBehaviour
{

    public bool isLeftHand, isRightHand, exit;
    // Start is called before the first frame update
    void Start()
    {
        //shouldn't be needed
        isLeftHand = false;
        isRightHand = false;
        exit = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Checks which hand enters the  collider & updates bool value accordingly
        if (other.tag == "LeftHand" )
        {
            isLeftHand = true;
            Debug.Log("Left Hand!");
        } else if ( other.tag == "RightHand")
        {
            isRightHand = true;
            Debug.Log("Right Hand!");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //Resets bool values
        isLeftHand = false;
        isRightHand = false;
        Debug.Log("Hand exited");
        exit = true;
    }
}
