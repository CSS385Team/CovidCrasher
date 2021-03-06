﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shop : MonoBehaviour
{
    [Header("List of items sold")]
    [SerializeField] private ShopItem[] shopItems;


    [Header("References")]
    [SerializeField] private Transform shopContainer;
    [SerializeField] private GameObject shoppContainerObjectfromScene;
    [SerializeField] private GameObject equipmentItemTemplate;
    [SerializeField] private GameObject consumableItemTemplate;
    [SerializeField] private GameObject clickerItemTemplate;
    [SerializeField] private GameObject weaponItemTemplate;

    [Header("Responsive UI Shop setting")]
    public RectTransform UIMask; //Store Mask 
    public GridLayoutGroup ShopContainerGlg; //Store container grid 
    private bool ShopShown = false;

    private void Start()
    {
        PopulateShop();
        resizeStoreGrid();
        shoppContainerObjectfromScene.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ShopShown = !ShopShown;
            shoppContainerObjectfromScene.SetActive(ShopShown);
        }
    }

    private void PopulateShop()
    {
        GameObject itemObject;
        for (int i = 0; i < shopItems.Length; i++)
        {
            ShopItem theItem = shopItems[i];
            //1: consumable 2: Equipment 3: Weapon Upgrade 4: Clicker Upgrade
            if (shopItems[i].itemTypeID == 1)
            {
                itemObject = Instantiate(consumableItemTemplate, shopContainer);
                itemObject.GetComponent<Item>().setItemTypeID(1);
                //  itemObject.GetComponent<AddToInventory>().InventoryItemPrefab = shopItems[i].ImagePrefab;
            }
            else if (shopItems[i].itemTypeID == 2)
            {
                itemObject = Instantiate(equipmentItemTemplate, shopContainer);
                itemObject.GetComponent<Item>().setItemTypeID(2);
                //  itemObject.GetComponent<Equipment>().EquipmentItemPrefab = shopItems[i].ImagePrefab; 
            }
            else if (shopItems[i].itemTypeID == 3)
            {
                itemObject = Instantiate(weaponItemTemplate, shopContainer);
                itemObject.GetComponent<Item>().setItemTypeID(3);
                //  itemObject.GetComponent<Equipment>().EquipmentItemPrefab = shopItems[i].ImagePrefab; 

            }
            else
            {
                itemObject = Instantiate(clickerItemTemplate, shopContainer);
                itemObject.GetComponent<Item>().setItemTypeID(4);
            }

            itemObject.GetComponent<Item>().ItemPrefab = shopItems[i].ImagePrefab;
            itemObject.GetComponent<Item>().setItemID(i);
            itemObject.GetComponent<Item>().setPrice(shopItems[i].price);
            itemObject.GetComponent<Item>().setDescription(shopItems[i].itemDescription);
            
            itemObject.transform.GetChild(0).GetComponent<Image>().sprite = shopItems[i].assetImage;
            itemObject.transform.GetChild(1).GetComponent<Text>().text = shopItems[i].price + "";
            itemObject.transform.GetChild(2).GetComponent<Text>().text = shopItems[i].itemName;
        }
    }


    private void resizeStoreGrid()
    {
        Vector2 newSize = ShopContainerGlg.cellSize;
        newSize.x = UIMask.rect.width;
        newSize.y = ShopContainerGlg.cellSize.y;
        ShopContainerGlg.cellSize = newSize;
    }

}
