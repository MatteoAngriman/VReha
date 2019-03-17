using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandChecker : MonoBehaviour
{
    public GameObject man;
    public ButtonManager butt;
    public bool isLeftHand, isRightHand, exit;
    // Start is called before the first frame update
    void Start()
    {
        //shouldn't be needed
        isLeftHand = false;
        isRightHand = false;
        man = GameObject.Find("HulaHop");
        var b = GameObject.Find("HulaHop");
        butt = b.GetComponent<ButtonManager>();
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

        Debug.Log("Hand exited");
        var van = man.GetComponent<ButtonManager>();
        if ((isLeftHand && butt.hand == 0) || (isRightHand && butt.hand == 1))
        {
            van.Reset();
            van.ChooseNextButton(Random.Range(0, 8), Random.Range(0, 2));
            //Resets bool values
            isLeftHand = false;
            isRightHand = false;
        }
    }
}
