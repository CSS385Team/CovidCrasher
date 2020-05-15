
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

        blasterWeapon();
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
        // not sure what the parameter 'int button' is supposed to do for GetMouseButtonDown(int button)
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(projectile, pos.position, pos.rotation);
        }
    }

    void blasterWeapon()
    {
        // not sure what the parameter 'int button' is supposed to do for GetMouseButton(int button)
        if (Input.GetMouseButton(0) && (Time.time - timeSpawn) > 0.5f)
        {
            timeSpawn = Time.time;
            Debug.Log(pos.rotation.z );
            Instantiate(projectile, pos.position, pos.rotation);
            //Quaternion aim = Quaternion.Euler(pos.rotation.x, pos.rotation.y, pos.rotation.z + 10f);
            //projectile.transform.rotation = aim;
        }

    }

    // this public method can be used to change the weapon that is equipped
    public void equipWeapon(GameObject weapon)
    {
        projectile = weapon;
    }
}
