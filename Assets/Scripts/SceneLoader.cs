using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int sceneID, exID;
    //public ExerciseData exData;

    // Start is called before the first frame update
    void Start()
    {
        sceneID = 0;
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetSceneID(int id)
    {
        sceneID = id;
        Debug.Log("Loaded scene " + sceneID);
    }

    public void LoadScene()
    {
        //Function that loads the scene given its ID
        if (sceneID > 0)
        {
            SceneManager.LoadScene(sceneID);
        }

    }
}