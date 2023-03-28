using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;


public class ONCLICK : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int textlvl =0;
    private string[] dialogue = new string[50];
    private int i=0;
    void Start()
    {
        dialogue[0] = "";
        dialogue[1] = "What is it with this TV?";
        dialogue[2] = "Strange... It does not have any buttons to start it";
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    private  void OnMouseDown()
    {
        i++;
        Debug.Log(i);
        text.text = dialogue[i];
        
       
    }
}
