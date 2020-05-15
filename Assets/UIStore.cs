using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStore : MonoBehaviour
{
    private Transform shopItemTemplate;
    // Start is called before the first frame update

    void Start()
    {
        shopItemTemplate = transform.Find("ShopItemTemplate");
        shopItemTemplate.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
