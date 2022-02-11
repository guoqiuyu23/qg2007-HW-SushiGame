using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class SashimiDictionary : MonoBehaviour
{

    private Dictionary<string, int> sushiOwned = new Dictionary<string, int>();
    public static bool createSushi = false;
    public static bool oderSushi = false;
    public static string enteredsashimi;
    
    public static string oderSushi1;
    public static string oderSushi2;
    public static string oderSushi3;
    public static int currentPrice;
    
    public static bool sushiHasBeenOrdered = false;
    
    public Text TextKai;
    public Text TextUni;
    public Text TextSalmon;
    public Text TextMoney;

    private void Start()
    {
       
        sushiOwned.Add("uni", 0);
        sushiOwned.Add("salmon", 0);
        sushiOwned.Add("kai", 0);
        sushiOwned.Add("null", 9999999);
        sushiOwned.Add("money", 0);
        
    }

    void Update()
    {
        // Debug.Log("createSushi"+createSushi);
        if (createSushi == true)
        {
            AddResource(enteredsashimi, 1);
            Debug.Log("add");
            createSushi = false;
        }
        
        
        if (oderSushi == true)
        {
            RemoveResources(oderSushi1,oderSushi2,oderSushi3, 1, currentPrice);
            
            Debug.Log("oder");
            oderSushi = false;
        }
        
        
        DisplayResources();
    }

    public void AddResource(string sushiType, int amountToAdd)
    {
        sushiOwned[sushiType] = sushiOwned[sushiType] + amountToAdd;
        Debug.Log("You own " + sushiOwned[sushiType] + " of " + sushiType);
    }
    
    
    public void DisplayResources()
    {
        TextKai.text = sushiOwned["kai"].ToString();
        TextUni.text = sushiOwned["uni"].ToString();
        TextSalmon.text = sushiOwned["salmon"].ToString();
        TextMoney.text = "Score: " + sushiOwned["money"].ToString();
    }

    public bool HasEnoughResources(string sushiType1 ,string sushiType2, string sushiType3, int amount)
    {
        if ( sushiOwned[sushiType1] < amount ||
             sushiOwned[sushiType2] < amount ||
             sushiOwned[sushiType3] < amount
             )
        { return false;}
        else {return true;}
    }
    
    public  void RemoveResources(string sushiType1 ,string sushiType2, string sushiType3, int cost, int price)
    {
        if (HasEnoughResources(sushiType1, sushiType2,sushiType3,cost) == true)
        {
            sushiOwned[sushiType1] = sushiOwned[sushiType1] - cost;
            sushiOwned[sushiType2] = sushiOwned[sushiType2] - cost;
            sushiOwned[sushiType3] = sushiOwned[sushiType3] - cost;
            
            sushiOwned["money"] = sushiOwned["money"]  + price;
            sushiHasBeenOrdered = true;
        }
    }
    
    
}
    
    
 
