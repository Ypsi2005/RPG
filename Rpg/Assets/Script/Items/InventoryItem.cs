using UnityEngine;
using System.Collections;

[System.Serializable] //  Our Representation of an InventoryItem
public class InventoryItem {
    public string itemName = "New Item"; //  What the item will be called in the inventory
    public Texture2D itemIcon = null; //  What the item will look like in the inventory
    public Rigidbody itemObject = null; //  Optional slot for a PreFab to instantiate when discarding

    public float atk;
    public float mag;
    public float agi;
    public float acc;
    public float fokus;
    public float def;
    public float mdf;
    public float luk;
    public float cha;
    public float wisdom;
    public float dex;
    
    public bool isUnique;

    public bool isIndestructible;

    public bool isQuestItem;
    public bool isStackable;
    public bool destroyOnUse;
    public float encumbranceValue;
}