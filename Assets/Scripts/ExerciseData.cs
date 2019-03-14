using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Exercise Data")]
public class ExerciseData : ScriptableObject
{
    public int exerciseID;
    public GameObject prefabToLoad;
    public float timeLimit;
    public bool isSpeedMod, isSittingMod, isSittingForced;
}
