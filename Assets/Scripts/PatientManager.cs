using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PatientManager : MonoBehaviour
{
    public Patient patient;
    public string patientName;
    public TMPro.TMP_Dropdown drop;

    // get the name of the value chosen by the dropdown menu
    public void GetDropdownValue()
    {
        patientName = drop.options[drop.value].text;
        Debug.Log("Name to load: " + patientName);
    }

    // Load Patient from name
    public void LoadPatientWithName(string name)
    {
        Debug.Log("Name to Load:" + name);
        patient = (Patient)AssetDatabase.LoadAssetAtPath("Assets/Patients/" + name + ".asset", typeof(Patient));
        Debug.Log("Patient loaded: " + patient.patName);
    }

    //Load patient from value taken in this script
    public void LoadPatient()
    {
        Debug.Log("Name to Load:" + patientName);
        patient = (Patient)AssetDatabase.LoadAssetAtPath("Assets/Patients/"+patientName+".asset", typeof(Patient));
        Debug.Log("Patient loaded: " + patient.patName);
    }

    public void DeletePatient()
    {
        AssetDatabase.DeleteAsset("Assets/Patients/" + patientName + ".asset");
        Debug.Log("Paziente " + patientName + " obliterato");
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
