
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This class provides the functionality
 * for allowing the player character to 
 * spawn weapon projectiles at the press 
 * of a button.
 */
public class Shooting : MonoBehaviour
{
    public Transform pos;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
        switch(projectile)
        {
            // case ThrowableWeapon:
                // throwWeapon();
            // case Blaster:
                // blasterWeapon();
        }
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
        if(Input.GetMouseButtonDown(1))
        {
            Instantiate(projectile, pos.position, pos.rotation);
        }
    }

    void blasterWeapon()
    {
        // not sure what the parameter 'int button' is supposed to do for GetMouseButton(int button)
        if (Input.GetMouseButton(1))
        {
            Instantiate(projectile, pos.position, pos.rotation);
        }
    }
}
