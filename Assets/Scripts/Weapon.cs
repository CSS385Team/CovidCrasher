
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This class provides the functionality
 * for allowing the player character to 
 * spawn weapon projectiles at the press 
 * of a button.
 */
public class Weapon : MonoBehaviour
{
    public Transform pos;
    public GameObject projectile;
    private float timeSpawn = 0f;
    public WaterBlaster water;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // https://answers.unity.com/questions/855976/make-a-player-model-rotate-towards-mouse-location.html
        // above is reference from which I obtained the three lines of code below
        // have a vector that holds mouse position in screen
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10f);

        // call method that calculates angle between mouse and player character
        float angle = AngleBetweenPoints(pos.position, mouseWorldPosition);

        // rotate player accordingly, had to add 180f because due to the sprites orientation, player would look behind the mouse
        pos.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle + 180f));

        /*
         * switch case statement goes in the update function
         * check which game object type projectile is.
         * based on the type, update will call a different 
         * method that handles shooting the projectile
         * appropriately.
         * 
         * Example: throwable weapons can be thrown
         * once per click, while guns can fire
         * successively while holding the mouse down.
         */

        /*
       switch(projectile)
       {
           case ThrowableWeapon:
               throwWeapon();
           case WaterBlaster.:
               blasterWeapon();
       }*/

        blasterWeapon(angle);
    }


    // https://answers.unity.com/questions/855976/make-a-player-model-rotate-towards-mouse-location.html
    // this method that calculates the angle between two vectors was found from the source above
    float AngleBetweenPoints(Vector2 a, Vector2 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }

    /*
     * This method is called in the update function
     * if the weapon equipped by the player is a
     * throwable weapon. This weapon will only spawn
     * during the frame the player presses the mouse
     * button down.
     */
    void throwWeapon()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(projectile, pos.position, pos.rotation );
        }
    }

    // this method handles instantiating the water gun bullets
    void blasterWeapon(float angle)
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Activated!");
            water.tripleShot = !water.tripleShot;
        }

        if (Input.GetMouseButton(0) && (Time.time - timeSpawn) > 0.5f)
        {
            timeSpawn = Time.time;
            
            // activate triple shot upgrade
            if (water.tripleShot)
            {
                Debug.Log("Triple Shot");
                Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0f, 0f, angle + 90f))); // straight shot
                Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0f, 0f, angle + 135f))); // slightly upwards
                Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0f, 0f, angle + 50f))); // slightly downwards

            }
            // do a single shot
            else
            {
                Debug.Log("Single Shot");
                Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0f, 0f, angle + 90f)));
            }
        }

    }

    // this public method can be used to change the weapon that is equipped
    public void equipWeapon(GameObject weapon)
    {
        projectile = weapon;
    }
}
