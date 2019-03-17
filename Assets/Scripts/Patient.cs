using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
//[CreateAssetMenu(fileName = "Patient")]
public class Patient
{
    public string patName;
    public string patAge;
    public char patSex;

    public List<Score> patScore = new List<Score>();

    public Patient(string name, string age, char sex)
    {
        patName = name;
        patAge = age;
        patSex = sex;
        patScore = new List<Score>
        {
            new Score(0, 0)
        };
    }
}

[System.Serializable]
public class Score
{
    public int gameID, gameScore;

    public Score(int newGameID, int newGameScore)
    {
        gameID = newGameID;
        gameScore = newGameScore;
    }
}
