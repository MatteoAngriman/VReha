using System.Collections;
using System.Collections.Generic;
using System.IO;
//using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CreatePatientAsset : MonoBehaviour
{
    //public string name;
    //public int age;
    public char sex;
    public InputField age, pName;
    public Dropdown sexDrop;

   //[MenuItem("Patient")]
   public void CreatePatient()
    {
        if (sexDrop.value == 0)
        {
            sex = 'f';
        } else sex = 'm';
        Patient pat = ScriptableObject.CreateInstance<Patient>();
        pat.patName = pName.text;
        Debug.Log("patient name: " + pat.patName);
        pat.patAge = age.text;
        Debug.Log("patient age: " + pat.patAge);
        pat.patSex = sex;
        Debug.Log("patient sex: " + pat.patSex);
        var JSONString = JsonUtility.ToJson(pat);
        File.WriteAllText(Application.persistentDataPath +"/Pazienti/"+ pName.text+".json", JSONString);
        
        //ONLY FOR UNITYEDITOR
        //UnityEditor.AssetDatabase.CreateAsset(pat, "Assets/Patients/" + pName.text + ".asset");
    }

}
