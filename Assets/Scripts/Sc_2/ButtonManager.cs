using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public GameObject button;
    public Material leftMat, rightMat, defMat;
    public GameObject[] bottoni;
    public GameObject[] pulsanti;
    public int hand, points = 0;
    public float timer = 0f;
    public float wait = 180.0f;
    public ButtonHandChecker butt;
    public ButtonActivatorScript activatorscript;  //per usare il deactivator di quello script

    // Start is called before the first frame update
    private void Start()
    {

        ChooseNextButton(Random.Range(0, 8), Random.Range(0, 2));
        /*
        for (int i = 0; i < 8; i++)
        {
            pulsanti = GameObject.FindGameObjectsWithTag("pulsante");
            //bottoni = GameObject.FindGameObjectsWithTag("bottone");
        }
        */




    }

    void Update()
    {
        timer += Time.deltaTime;
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Reset();
            ChooseNextButton(Random.Range(0, 8),Random.Range(0, 2));
        }
        
    }

    public void Reset()
    {
        for (int i = 0; i < pulsanti.Length; i++)     //ciclo per resettare il materiale dei bottoni
        {
            Renderer rend = pulsanti[i].GetComponent<Renderer>();
            rend.material = defMat;
        }
    }
    

    public void ChooseNextButton(int i, int lr)
    {
        Debug.Log("dentro choosenextbutton, il bottone è il nr: " + i);
        button = bottoni[i];
        //butt = button.GetComponentInChildren<ButtonHandChecker>();
        activatorscript = button.GetComponentInChildren<ButtonActivatorScript>();
        Debug.Log(activatorscript.deactivated.ToString());
        /*
        if (activatorscript.deactivated && timer<wait)
        {
            int hand = lr;
                if (hand == 0)
                    LightButton(pulsanti[i], leftMat);
                else
                    LightButton(pulsanti[i], rightMat);
            Reset();
            return ChooseNextButton(Random.Range(0, 8), Random.Range(0, 2));
        }
        return 0;
        */
            if(activatorscript.deactivated)
            {
                Debug.Log("DEACTIVATED DIO BUBI");
                button = bottoni[i];
                hand = lr;
                if (hand == 0)
                {
                    LightButton(pulsanti[i], leftMat);
                    Debug.Log("Mano sinistra");
                }
                else
                {
                    LightButton(pulsanti[i], rightMat);
                    Debug.Log("Mano sinistra");
                }
            }
            /*
            Reset();
            return ChooseNextButton(Random.Range(0, 8), Random.Range(0,2));             
            */
        if(timer >= wait)
        {
            Debug.Log("Tempo Scaduto, hai schiacciato: " + points + " bottoni");
            SceneManager.LoadScene(0);
        }
    }
            

public void LightButton(GameObject but, Material mat)       //accendo il bottone prescelto del colore giusto
    {
        Renderer rend = but.GetComponent<Renderer>();
        rend.material = mat;
    }
}