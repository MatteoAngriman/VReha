using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadExercise : MonoBehaviour
{

    public GameObject[] exPrefabs;
    public GameObject sceneManager;
    private void Start()
    {
        StartExercise();
    }
    public void StartExercise()
    {
        sceneManager = GameObject.FindGameObjectWithTag("SceneManager");
        if (sceneManager != null)
        {
            var index = sceneManager.GetComponent<SetExerciseData>().ex_id;
            Debug.Log("Exercise ID to load");
            if (index > 0)
            {
                Instantiate(exPrefabs[index - 1]);
            }
        }
    }
}
