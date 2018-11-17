using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {
    public InventoryItemList list;


    void OnTriggerEnter2D(Collider2D other) {
        var rnd = Random.Range(0, list.itemList.Count);
        InventoryItem item = list.itemList[rnd];
        Debug.Log(item.itemName + " ATK: "+item.atk + " MAG: "+item.mag);
        Destroy(gameObject);
    }
}
