using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Scene Data")]
public class SceneData : ScriptableObject
{
    public int sceneID;
    public int exerciseID;
    public int patientID;
    public float speed;
    public bool isLeftHanded;
    public bool isSitting;


}
