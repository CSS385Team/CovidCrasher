using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HealthSystem : MonoBehaviour
{
    public int health = 5;

    // private UIScript ui;
    private int maxHealth;

    // Will be set to 0 or 1 depending on how the GameObject is tagged
    // it's -1 if the object is not a player
    private int playerNumber;
    private HealthBarAdjust healthBarAdjust;
    private ShieldBarAdjust shieldBarAdjust;
    private int shield;


    private bool inGracePeriod;

    private void Start()
    {
        // Find the UI in the scene and store a reference for later use
        // ui = GameObject.FindObjectOfType<UIScript>();

        // Set the player number based on the GameObject tag
        switch (gameObject.tag)
        {
            case "Player":
                playerNumber = 0;

                break;
            default:
                playerNumber = -1;
                break;
        }
        if (playerNumber == 0 || playerNumber == 1)
        {
            healthBarAdjust = GameObject.Find("healthBarContainer").GetComponent<HealthBarAdjust>();
            shieldBarAdjust = GameObject.Find("shieldContainer").GetComponent<ShieldBarAdjust>();
        }
        // Notify the UI so it will show the right initial amount
        // if (ui != null
        //     && playerNumber != -1)
        // {
        //     ui.SetHealth(health, playerNumber);
        // }

        maxHealth = health; //note down the maximum health to avoid going over it when the player gets healed
        if (playerNumber == 0 || playerNumber == 1)
            healthBarAdjust.SetMaxHealth(maxHealth);
        shield = 0;
    }


    // changes the energy from the player
    // also notifies the UI (if present)
    public void ModifyHealth(int amount)
    {
        if (!inGracePeriod)
        {
            if (shield > 0 && amount < 0)
            {
                shield--;
                shieldBarAdjust.setShield(shield);
            }
            else
            {
                // Avoid going over the maximum health
                if (health + amount > maxHealth)
                {
                    amount = maxHealth - health;
                }

                health += amount;
                // Notify the UI so it will change the number in the corner
                // if (ui != null
                //     && playerNumber != -1)
                // {
                //     ui.ChangeHealth(amount, playerNumber);
                // }
                if (playerNumber == 0 || playerNumber == 1)
                {
                    Debug.Log("Player Health modified");
                    healthBarAdjust.SetHealth(health);
                }
                // Dead
                if (health <= 0)
                {
                    if (playerNumber == 0 || playerNumber == 1)
                    {
                        gameObject.SetActive(false);
                        //Destroy(gameObject);
                    }
                    else
                    {
                        /* change from destroy to death sprite */
                        Destroy(gameObject);
                    }
                }
            }
        }
    }

    public void setShield(int unit)
    {
        shield = unit;
        shieldBarAdjust.buyShield(unit);
    }

    public void setGracePeriod(float second)
    {
        inGracePeriod = true;
        Invoke("expireGracePeriod", second);
    }

    private void expireGracePeriod()
    {
        inGracePeriod = false;
    }

    void OnDestroy()
    {
        if (this.gameObject.CompareTag("Boss"))
        {
            SceneManager.LoadScene("YouWin");
        }
    }
}
