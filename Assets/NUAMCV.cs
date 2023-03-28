using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NUAMCV : MonoBehaviour
{  public TextMeshProUGUI text;
    public GameObject CAnvass;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X)) { CAnvass.SetActive(true); text.text = " What is happening? I need my pills"; }
    }
}
