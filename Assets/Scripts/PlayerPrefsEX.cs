using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsEX : MonoBehaviour
{
    public int aInt;
    public float aFloat;
    public string aString;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //save
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Save");

            PlayerPrefs.SetInt("testInt", aInt);
            PlayerPrefs.SetFloat("testFloat", aFloat);
            PlayerPrefs.SetString("testString", aString);
        }

        //load
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Load");

            if (PlayerPrefs.HasKey("testInt"))
            {
                aInt = PlayerPrefs.GetInt("testInt");
                aFloat = PlayerPrefs.GetFloat("testFloat");
                aString = PlayerPrefs.GetString("testString");
            } else
            {
                Debug.Log("No PlayerPrefs Data Found");
            }
        }

        //clear
        if (Input.GetKeyDown(KeyCode.C))
        {
            PlayerPrefs.DeleteAll();

            Debug.Log("Deleted PlayerPrefs Data");
        }
    }
}
