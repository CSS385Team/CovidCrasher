using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToInventory : MonoBehaviour
{
    private PlayerInventory inventory;
    public GameObject InventoryItemPrefab;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerInventory>();    
    }

    public void addItemToInventory()
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false)
            {
                inventory.isFull[i] = true;
                inventory.itemsAtSlots[i] = Instantiate(InventoryItemPrefab, inventory.slots[i].transform, false);
                break;
            }

        }
    }

    public void setImagePrefab(GameObject imagePrefab)
    {
        InventoryItemPrefab = imagePrefab;
    }

}
