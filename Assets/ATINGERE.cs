using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ATINGERE : MonoBehaviour
{
    public int seIntampla=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        SceneManager.LoadScene("Lvl5");
    }
}
