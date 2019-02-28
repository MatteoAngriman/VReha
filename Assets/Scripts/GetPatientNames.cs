using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GetPatientNames : MonoBehaviour
{

    public TMPro.TMP_Dropdown patDrop;
    private string[] patients;
    // Start is called before the first frame update
    private void Start()
    {
        UpdateDropdownList();
    }
    public void UpdateDropdownList()
    {
        patients = getPatientNames();
        patDrop.options.Clear();
        foreach(string pat in patients)
        {
            patDrop.options.Add(new TMPro.TMP_Dropdown.OptionData() { text = Path.GetFileNameWithoutExtension(pat) });
        }

        Debug.Log("Lista aggiornata");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string[] getPatientNames()
    {
        string path = Application.dataPath + "/Patients";
        string[] patNames = Directory.GetFiles(@path, "*.asset");
        foreach(string pat in patNames)
        {
            Debug.Log(pat);
        }

        return patNames;
    }
}
