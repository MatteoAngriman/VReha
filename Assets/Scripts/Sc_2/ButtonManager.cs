using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public GameObject button;
    public Material leftMat, rightMat, defMat;
    public GameObject[] bottoni;
    public int points = 0;
    public int c = 0; //counter brutto per debug
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChooseButton();

        }
    }

    public void ChooseButton()      //scelgo il bottone e scelgo con che mano devo premerlo
    {
        if(c >= 1)
        {
            for(int i=0; i<=7; i++)     //ciclo per resettare il materiale dei bottoni
            {
                Renderer rend = bottoni[i].GetComponent<Renderer>();
                rend.material = defMat;
            }
        }
        int r = Random.Range(0, 8);         //bottone random
        button = bottoni[r];
        Debug.Log("Il bottone scelto è il nr: " + r);
        int lr = Random.Range(0, 2);    //sinistra o destra
        if (lr == 0)
        {
            LightButton(button, leftMat);
            Debug.Log("SINISTRA");
        }
        else
        {
            LightButton(button, rightMat);
            Debug.Log("Destra");
        }
        c++;

    }

    public void LightButton(GameObject but, Material mat)       //accendo il bottone prescelto del colore giusto
    {
        Renderer rend = but.GetComponent<Renderer>();
        rend.material = mat;
    }
}
