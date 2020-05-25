using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoapGra : MonoBehaviour
{
    public GameObject soapGradnadePrefab;
    public float throwForce = 20f;
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


        //Ray rayCast = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Instantiate(soapGradnadePrefab, rayCast.GetPoint(10), Quaternion.identity);

        var player = GameObject.FindGameObjectWithTag("Weapon");

        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10f);

        // call method that calculates angle between mouse and player character
        float angle = AngleBetweenPoints(player.transform.position, mouseWorldPosition);

        float AngleBetweenPoints(Vector2 a, Vector2 b)
        {
            return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
        }

        var grenade = Instantiate(soapGradnadePrefab, player.transform.position, Quaternion.Euler(new Vector3(0f, 0f, angle + 90f)));
    }
}
