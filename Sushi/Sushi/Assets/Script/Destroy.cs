using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //public bool createSushi = false;
    //public string enteredsashimi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject); 
        SashimiDictionary.enteredsashimi = other.gameObject.GetComponent<SashimiInformation>().sashimiType;
        // GameManager._SashimiDictionary.AddResource(enteredsashimi, 1);
       // Destroy(other.gameObject);
       float currentx = other.transform.position.x;
       other.transform.position = new Vector2(currentx, 6);
       SashimiDictionary.createSushi = true;
    }
}
