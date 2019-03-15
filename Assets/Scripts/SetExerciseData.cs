using System.Collections;
using System.Collections.Generic;
//using UnityEditor;
using UnityEngine;

public class SetExerciseData : MonoBehaviour
{
    public ExerciseData exData;
    public int speed;
    public bool isSitting;
    public float timeLimit;

    public void ExerciseDataLoader(int id)
    {

        var res = Resources.Load<ExerciseData>("ExerciseData/Ex" + id + ".asset");
        //var bundle = AssetBundle.LoadFromFile("Assets/ExerciseData/Ex" + id + ".asset");
        exData = res;
        //exData = JsonUtility.FromJson<ExerciseData>();
        //exData = (ExerciseData)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/ExerciseData/Ex" + id + ".asset", typeof(ExerciseData));
        Debug.Log("Exercise Data for Ex" + id + " are loaded");
    }
    public void SetSpeed(int sp)
    {
        exData.speed = sp;
        //speed = sp;
    }

    public void SetSitting(bool isSit)
    {
        exData.isSitting = isSit;
    }

    public void SetTimeLimit(float tl)
    {
        exData.timeLimit = tl;
    }
}
