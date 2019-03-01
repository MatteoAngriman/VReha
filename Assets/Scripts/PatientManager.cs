using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientManager : MonoBehaviour
{
    public Patient patient;

    public void GetPatient (Patient pat)
    {
        patient = pat;
    }

    public void AddScore(int gameID, int gameScore)
    {
        patient.patScore.Add(new Score(gameID, gameScore));
        patient.patScore.Sort();
    }

    public void GetScores (int gameID)
    {
        foreach (Score sc in patient.patScore)
        {
            if (sc.gameID == gameID)
                {
                Debug.Log("Score in game " + gameID + " is " + sc.gameScore);
            };
        }
    }
}
