using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UIScoreUpdater : MonoBehaviour
{

    public TextMeshProUGUI actualScore, recordScore;
    private PatientManager pat;
    private SceneLoader data;

    private void Start()
    {
        pat = FindObjectOfType<PatientManager>();
        data = FindObjectOfType<SceneLoader>();
        UpdateRecordScore(pat.patient, data.exID);
    }

    public void UpdateActualScore(int sc)
    {
        actualScore.text = sc.ToString();
    }

    public void UpdateRecordScore(Patient pat, int id)
    {
        var maxScore = 0;
        if(pat.patScore.Count == 0)
        {
            throw new InvalidOperationException("Empty list");
        }
        foreach(Score s in pat.patScore)
        {
            if (s.gameID == id)
            {
                if(s.gameScore > maxScore)
                {
                    maxScore = s.gameScore;
                } 
            }
        }
    }
}
