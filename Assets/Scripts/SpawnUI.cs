using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUI : MonoBehaviour
{
    public GameObject UI;
    public Canvas toActivate;
public void UISpawn()
    {
        Instantiate(UI);
    }

public void CanvasActivator()
    {
        toActivate.enabled = true;
    }
public void CanvasDeactivator()
    {
        toActivate.enabled = false;
    }
    public void DestroyUI()
    {
        var canvas = transform.parent.gameObject;
        Destroy(canvas);
    }
}
