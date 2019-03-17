using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadExercise : MonoBehaviour
{

    public GameObject[] exPrefabs;
    public GameObject sceneManager;
    private void Start()
    {
        sceneManager = GameObject.FindGameObjectWithTag("SceneManager");
        StartExercise();
    }
    public void StartExercise()
    {
        var index = sceneManager.GetComponent<SetExerciseData>().exData.exerciseID;
        Debug.Log("Exercise ID to load");
        if (index > 0)
        {
            Instantiate(exPrefabs[index-1]);
        }
    }
}
