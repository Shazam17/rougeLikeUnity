using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    itemScript[] items = new itemScript[5];
    public int inventorySize = 5;
    private int stackPointer = 0;
    void updateUI()
    {

    }

    void addItem(itemScript item)
    {
        if(stackPointer != inventorySize)
        {
            items[stackPointer] = item;
            stackPointer++;
        }
       
    }
   
}
