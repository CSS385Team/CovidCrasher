using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Shop/Shop Item")]
public class ShopItem : ScriptableObject
{
    [Header("1: consumable 2: Equipment 3: Weapon Upgrade 4: Clicker Upgrade")]
    public int itemTypeID;
    public string itemName;
    [Header("Display Asset Prefab")]
    public GameObject ImagePrefab;
    public int price;
    
    //1: consumable 2: Equipment 3: Weapon Upgrade 4: Clicker Upgrade
    
    
}
