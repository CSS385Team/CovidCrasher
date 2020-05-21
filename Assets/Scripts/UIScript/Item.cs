using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Item : MonoBehaviour {
    
    public GameObject ItemPrefab;
    public GameObject DescriptionTemplate;
    private GameObject DescriptionTemplate1;
    private int itemID;
    private int itemTypeID;
    private int price;
    public GameObject[] clickerManager;
    public GameObject youDontHaveEnoughAlert;
    private string itemDescription;

    private void Start()
    {
        clickerManager = GameObject.FindGameObjectsWithTag("GameController");
       // Debug.Log(itemDescription);
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
            GameObject alert; 
            alert = Instantiate(youDontHaveEnoughAlert, gameObject.transform, false);
            Destroy(alert, 1);

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

    public void setDescription(string des)
    {
        this.itemDescription = des;
    }
    
    public void displayDes()
    {
        Debug.Log(itemDescription);
        DescriptionTemplate1 = Instantiate(DescriptionTemplate, gameObject.transform.parent.parent.parent.parent);
        DescriptionTemplate1.transform.GetChild(0).GetComponent<Text>().text = itemDescription;
    }

    public void destroyDes()
    {
        Destroy(DescriptionTemplate1);
    }

}

