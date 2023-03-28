using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HAIFRATE : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (a.GetComponent<Schimbare>().i == 2 && b.GetComponent<Schimbare>().i == 3 && c.GetComponent<Schimbare>().i == 0) { Debug.Log("Bravo"); SceneManager.LoadScene("Lvl4"); }
    }
}
