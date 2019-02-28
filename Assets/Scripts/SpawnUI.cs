using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUI : MonoBehaviour
{
    public GameObject UI;
public void UISpawn()
    {
        Instantiate(UI);
    }

    public void DestroyUI()
    {
        var canvas = transform.parent.gameObject;
        Destroy(canvas);
    }
}
