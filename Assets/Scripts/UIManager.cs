using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image leftOn, rightOn;
    
    public void CloseApplication()
    {
        Application.Quit();
    }

    public void TurnImageOn( int id)
    {
        //id = 0 is left hand, id = 1 is right hand
        switch (id)
        {
            case 0:
                if (leftOn.enabled == true)
                {
                    leftOn.enabled = false;
                }
                else leftOn.enabled = true;
                break;
            case 1:
                if (rightOn.enabled == true)
                {
                    rightOn.enabled = false;
                }
                else rightOn.enabled = true ;
                break;
        }
    }
}
