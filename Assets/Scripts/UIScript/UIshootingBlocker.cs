using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIshootingBlocker : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler {
    private Weapon weaponScript;

    private void Start()
    { 
        weaponScript = GameObject.FindGameObjectsWithTag("Player")[0].transform.GetChild(0).GetComponent<Weapon>();
    }
    // Start is called before the first frame update
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        weaponScript.blockShoot();
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        weaponScript.allowShoot();
    }

    public void OnDisable()
    {
        if (weaponScript != null)
        weaponScript.allowShoot();
    }
    
}
