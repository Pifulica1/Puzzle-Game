using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SESCHIMBATEXTPLUSFINALOMFG : MonoBehaviour
{
    public GameObject canvas;
    public TextMeshProUGUI text;
    public string[] dialog= new string[100];
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        dialog[1] = "I don't want to see this anymore";
        dialog[2] = " That's right! My pills! Evereything will be ok if I jsut take my pills!";
        dialog[3] = " Press y to use pills";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.X)) { i++; text.text = dialog[i];  }
        if(Input.GetKeyUp(KeyCode.Y)) { SceneManager.LoadScene("Lvl66"); }
    }
}
