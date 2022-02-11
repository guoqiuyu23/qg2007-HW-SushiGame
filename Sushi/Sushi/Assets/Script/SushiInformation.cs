using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiInformation : MonoBehaviour
{
    public string sushiType1;
    public string sushiType2;
    public string sushiType3;
    public int sushiPrice;
    
    private void OnMouseDown()
    {
        SashimiDictionary.oderSushi1 = sushiType1;
        SashimiDictionary.oderSushi2 = sushiType2;
        SashimiDictionary.oderSushi3 = sushiType3;
        SashimiDictionary.currentPrice = sushiPrice;
        SashimiDictionary.oderSushi = true;
    }

    private void Update()
    {
        // if (SashimiDictionary.sushiHasBeenOrdered == true) ;
        // {
        //     Destroy(gameObject);
        //    SashimiDictionary.sushiHasBeenOrdered = false;
        //    GameManager.createNewOder = true;
        //
        // }
        
    }
}
