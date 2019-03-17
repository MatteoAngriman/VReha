using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPoints : MonoBehaviour
{
    [HideInInspector]
    public Dodge doge;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag + other.gameObject.name);
        if(other.gameObject.name == "CenterEyeAnchor")
        {
            Debug.Log("L'oggetto con cui hai colliso è : " + other.gameObject.name);
            Debug.Log("devi SCHIVARE le palline");
            Destroy(this.gameObject);
            Debug.Log("Il tuo punteggio è: " +Dodge.points);
        }

        if(other.gameObject.name == "Wall")
        {
            Debug.Log("Pallina Schivata");
            Destroy(this.gameObject);
            Dodge.points+=1;
            Debug.Log("Il tuo punteggio è: " + Dodge.points);
        }
    }

    private void Update()
    {
        float t = 0;
        t += Time.deltaTime;
        if (t > 3.0f)
            Destroy(this.gameObject);
    }
}
