using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public GameObject button;
    public Material leftMat, rightMat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LightButton(GameObject but, Material mat)
    {
        //Change material for the button
        but.GetComponent<Renderer>().material = mat;
    }

}
