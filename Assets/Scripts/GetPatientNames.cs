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
        patDrop.options.Add(new TMPro.TMP_Dropdown.OptionData() { text = null });
        //patDrop.options.Add(new TMPro.TMP_Dropdown.OptionData() { text = "Seleziona il paziente" });
        foreach(string pat in patients)
        {
            patDrop.options.Add(new TMPro.TMP_Dropdown.OptionData() { text = Path.GetFileNameWithoutExtension(pat) });
        }
        //patDrop.options.RemoveAt(0);
        patDrop.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "Seleziona il paziente";
        Debug.Log("Lista aggiornata");

    }

    private string[] getPatientNames()
    {

        string path = Application.persistentDataPath + "/Pazienti"; /*Application.dataPath + "/Patients";*/
        string[] patNames = Directory.GetFiles(@path, "*.json");
        foreach(string pat in patNames)
        {
            Debug.Log(pat);
        }

        return patNames;
    }

}
