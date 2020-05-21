using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoapGra : MonoBehaviour
{
    public GameObject soapGradnadePrefab;
    void OnDestroy()
    {
        //var mousePos = Input.mousePosition;
        //mousePos.z = 2f;       // we want 2m away from the camera position

        //var objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        //Instantiate(soapGradnadePrefab, objectPos, Quaternion.identity);
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        ////Instantiate(soapGradnadePrefab, Input.mousePosition, Quaternion.identity);
        //Physics.Raycast(ray);
        //Instantiate(soapGradnadePrefab, transform.position, transform.rotation);

        Ray rayCast = Camera.main.ScreenPointToRay(Input.mousePosition);
        Instantiate(soapGradnadePrefab, rayCast.GetPoint(10), Quaternion.identity);
    }
}
