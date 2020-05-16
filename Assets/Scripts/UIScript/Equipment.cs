using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    private PlayerEquipment equipment;
    public GameObject EquipmentItemPrefab;

    private void Start()
    {
        equipment = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerEquipment>();    
    }

    public void addItemToEquipment()
    {
        if (equipment.Equiped != null)
        {
            Destroy(equipment.Equiped);
        }
        equipment.Equiped = Instantiate(EquipmentItemPrefab, equipment.EquipmentSlot.transform, false);
        Debug.Log("newPrefav");
    }
}
