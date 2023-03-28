using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schimbare : MonoBehaviour
{
    public Sprite[] MATA=new Sprite[100];
    public SpriteRenderer Renderer;
    public int i=0;
    void Start()
    {
        Renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnMouseDown()
    {
        i++;
        if (i > 3) i = 0;
        Debug.Log(i);
        Renderer.sprite = MATA[i];
        
    }
}
