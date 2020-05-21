using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
    
    public GameObject ItemPrefab;
    private int itemID;
    private int itemTypeID;
    private int price;
    public GameObject[] clickerManager;
    public GameObject youDontHaveEnoughAlert;

    private void Start()
    {
        clickerManager = GameObject.FindGameObjectsWithTag("GameController");
    }

    public void action()
    {
        if (priceCheck(clickerManager[0].GetComponent<GameControlScript>().strokesAmount))
        {

            if (itemTypeID == 1)
            {
                addItemToInventory();
            }
            else
            {
                addItemToEquipment();
            }
        } else
        {
            Debug.Log("you dont have money");
            GameObject alret; 
            alret = Instantiate(youDontHaveEnoughAlert, gameObject.transform, false);
            Destroy(alret, 1);

        }
    }
    
    private bool priceCheck(int myPoint)
    {
        if(myPoint < price)
        {
            return false;
        }
        clickerManager[0].GetComponent<GameControlScript>().strokesAmount -= price;
        return true;
    }

    public void addItemToInventory()
    {
        PlayerInventory inventory;
        inventory = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerInventory>();
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false)
            {
                inventory.isFull[i] = true;
                inventory.itemsAtSlots[i] = Instantiate(ItemPrefab, inventory.slots[i].transform, false);
                break;
            }

        }
    }

    public void addItemToEquipment()
    {
        PlayerEquipment equipment;
        equipment = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerEquipment>();
        if (equipment.Equiped != null)
        {
            Destroy(equipment.Equiped);
        }
        equipment.Equiped = Instantiate(ItemPrefab, equipment.EquipmentSlot.transform, false);
        Debug.Log("newPrefav");
    }

    public void setImagePrefab(GameObject imagePrefab)
    {
        ItemPrefab = imagePrefab;
    }

    public void setItemID(int itemID)
    {
        this.itemID = itemID;
    }

    public void setItemTypeID(int itemTypeID)
    {
        this.itemTypeID = itemTypeID;
    }

    public void setPrice(int price)
    {
        this.price = price;
    }
}

