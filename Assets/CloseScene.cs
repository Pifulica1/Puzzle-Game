using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CloseScene : MonoBehaviour
{
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X)) {Canvas.SetActive(false);}
    }
}
