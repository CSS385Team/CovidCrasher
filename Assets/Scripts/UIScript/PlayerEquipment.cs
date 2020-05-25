using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerEquipment : MonoBehaviour
{
    [Header("Inventory Slots")]
    public GameObject WeaponSlot;
    public GameObject EquipmentSlot;

    [Header("Current Weapon (Automatically Initalize)")]
    public GameObject Equiped;
    public GameObject PlayerWeapon;

    [Header("Default Weapon Prefab")]
    public GameObject defaultWeaponPrefab;

    private GameObject[] GunCollection;
    private int gunSize = 0;
    private int gunIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
       // PlayerWeapon = Instantiate(defaultWeaponPrefab, WeaponSlot.transform, false);
        GunCollection = new GameObject[3];
        GunCollection[0] = defaultWeaponPrefab;
        PlayerWeapon = Instantiate(GunCollection[0], WeaponSlot.transform, false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            changeGun();
        }
    }

    //called when new weapon is bought from the store 
    public void addtoGunCollection(GameObject gun)
    {
        gunSize++;
        GunCollection[gunSize] = gun;
        
    }

    //call when Z is pressed 
    public void changeGun()
    {
        gunIndex++;
        if (gunIndex > gunSize)
            gunIndex = 0;
        Debug.Log("GunIndex: " + gunIndex + "Gunsize:" + gunSize);
        Destroy(PlayerWeapon);
        PlayerWeapon = Instantiate(GunCollection[gunIndex], WeaponSlot.transform, false);
        WeaponSlot.transform.GetChild(2).GetComponent<Text>().text = "Weapon " + (gunIndex+1);


    }


}
