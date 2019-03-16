using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivatorScript : MonoBehaviour
{
    public ButtonHandChecker buttonHandChecker;
    public PatientManager patManager;
    public int score;
    private int gameID;

    private void Start()
    {
        gameID = 2;
        score = 0;
        patManager = FindObjectOfType<PatientManager>();
        Debug.Log(patManager.patient.name);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (buttonHandChecker.isLeftHand)
        {
            Debug.Log("Left Hand Activator");
            Debug.Log("Activated");
            score++;

        } else if (buttonHandChecker.isRightHand)
        {
            Debug.Log("Right Hand Activator");
            Debug.Log("Activated");
            score++;
        } else
        {
            Debug.Log("You pressed with the wrong hand!");
        }
        
    }

    public void OnExerciseEnd()
    {
        //patManager.patient.patScore.Add(new Score(gameID, score));
        patManager.AddScore(gameID, score);
    }
}
