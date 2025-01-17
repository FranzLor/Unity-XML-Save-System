using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System.Xml.Serialization;

using UnityEditor;

public class NewBehaviourScript : MonoBehaviour
{
    //testing saving string
    public string testingString;

    public List<float> testingList;

    public SaveData dataToSave;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //save string
        if (Input.GetKeyDown(KeyCode.S))
        {
            Save();
        }
        //load string
        if (Input.GetKeyDown(KeyCode.L))
        {
            Load();
        }
        //clear string
        if (Input.GetKeyDown(KeyCode.C))
        {
            ClearSave();
        }
        //open save file
        if (Input.GetKeyDown(KeyCode.O))
        {
            EditorUtility.RevealInFinder(Application.persistentDataPath);
            EditorUtility.RevealInFinder(Application.dataPath);
        }
    }

    void Save()
    {
        //STRING-------------------------
        //Debug.Log("Saving...");
        ////directory to save to
        //string dataPath = Application.persistentDataPath;

        ////create new XML serializer
        //var serializer = new XmlSerializer(typeof(string));
        //var stream = new FileStream(dataPath + "/Save.xml", FileMode.Create);
        //serializer.Serialize(stream, testingString);

        //stream.Close();
        //--------------------------------


        //LIST---------------------------
        //Debug.Log("Saving...");
        ////directory to save to
        //string dataPath = Application.persistentDataPath;

        ////create new XML serializer
        //var serializer = new XmlSerializer(typeof(SaveData));
        //var stream = new FileStream(dataPath + "/Save.xml", FileMode.Create);
        //serializer.Serialize(stream, dataToSave);

        //stream.Close();
        //--------------------------------
    }

    void Load()
    {
        //STRING-------------------------
        //string dataPath = Application.persistentDataPath;

        ////error check ensure file exists
        //if (File.Exists(dataPath + "/Save.xml"))
        //{
        //    Debug.Log("Loading Data");

        //    var serializer = new XmlSerializer(typeof(string));
        //    var stream = new FileStream(dataPath + "/Save.xml", FileMode.Open);
        //    testingString = serializer.Deserialize(stream) as string;
        //    stream.Close();
        //} else
        //{
        //    Debug.LogWarning("No Save File Found");
        //}
        //--------------------------------


        //LIST---------------------------
        //string dataPath = Application.persistentDataPath;

        ////error check ensure file exists
        //if (File.Exists(dataPath + "/Save.xml"))
        //{
        //    Debug.Log("Loading Data");

        //    var serializer = new XmlSerializer(typeof(SaveData));
        //    var stream = new FileStream(dataPath + "/Save.xml", FileMode.Open);
        //    dataToSave = serializer.Deserialize(stream) as SaveData;
        //    stream.Close();
        //}
        //else
        //{
        //    Debug.LogWarning("No Save File Found");
        //}
        //--------------------------------
    }

    void ClearSave()
    {
        ////error check ensure file exists
        //if (File.Exists(Application.persistentDataPath + "/Save.xml"))
        //{
        //    Debug.Log("Deleting Save File");

        //    File.Delete(Application.persistentDataPath + "/Save.xml");
        //} else
        //{
        //    Debug.LogWarning("No Save File Found");
        //}
    }
}
