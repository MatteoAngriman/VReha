using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandColorChanger : MonoBehaviour
{
    public GameObject[] left, right;

    // Start is called before the first frame update
    void Start()
    {
        left = GameObject.FindGameObjectsWithTag("LeftHand");
        right = GameObject.FindGameObjectsWithTag("RightHand");

        foreach(GameObject l in left){
            l.GetComponent<Material>().color = Color.red;
        }
        foreach(GameObject r in right)
        {
            r.GetComponent<Material>().color = Color.blue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
