using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Patient")]
public class Patient : ScriptableObject
{
    public string patName;
    public string patAge;
    public char patSex;

    public int[] patScore;

    public Patient(string name, string age, char sex)
    {
        patName = name;
        patAge = age;
        patSex = sex;

        patScore[0] = 0;
    }
}
