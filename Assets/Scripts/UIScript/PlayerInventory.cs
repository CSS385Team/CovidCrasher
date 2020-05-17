using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    //to check if the item is empty at the slot
    public bool[] isFull;
    public GameObject[] slots;
    public GameObject[] itemsAtSlots;

    private void Start()
    {
        itemsAtSlots = new GameObject[2];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            consumeSlot1();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            consumeSlot2();
        }
    }

    public void consumeSlot1()
    {
        //Will add itemsAtSlots[0].doSomeAction(); here
        Destroy(itemsAtSlots[0]);
        isFull[0] = false;
    }

    public void consumeSlot2()
    {
        //Will add itemsAtSlots[1].doSomeAction(); here
        Destroy(itemsAtSlots[1]);
        isFull[1] = false;
    }
}
