using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Exercise Data")]
public class ExerciseData : ScriptableObject
{
    public int exerciseID;
    public GameObject prefabToLoad;
    public float timeLimit;
    public bool isSpeedMod, isSittingMod, isSitting;
    public int speed;

    public static explicit operator ExerciseData(AssetBundle v)
    {
        throw new NotImplementedException();
    }
}
