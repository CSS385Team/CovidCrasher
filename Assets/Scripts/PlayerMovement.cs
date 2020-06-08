using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	// Used this YouTube video for help: https://www.youtube.com/watch?v=CeXAiaQOzmY
    /* Functional with WASD and arrow keys.
    Player character moves constantly at top speed,
    and stops as soon as the key is let go.*/
    
	public float speed;
    private Rigidbody2D rb;
    private Vector2 mv;
    private float tempSpeed;
    public GameObject gameOverPanel;
    public float speedBoostDuration = 3f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tempSpeed = speed;
        gameOverPanel = GameObject.Find("YouDiedPanel");
        gameOverPanel?.SetActive(false);
    }

    void Update()
    {
        Vector2 mi = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        mv = mi.normalized * speed;
 
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + mv * Time.fixedDeltaTime);
    }


    // Gabe: Funtion inspired by Playground Challenge Code "ConditionArea"
    void OnTriggerStay2D(Collider2D otherCollider)
	{
		if(otherCollider.CompareTag("Mucus"))
		{
            //Debug.Log("Collided!");
			this.speed = 2;
		}
        if(otherCollider.CompareTag("Saliva")) {
            StartCoroutine(speedBoost());
        }
	}

    IEnumerator speedBoost() {
        this.speed = 11;
        yield return new WaitForSeconds(speedBoostDuration);
        this.speed = tempSpeed;
    }

    private void OnTriggerExit2D(Collider2D otherCollider)
	{
		if(otherCollider.CompareTag("Mucus"))
		{
			this.speed = tempSpeed;
        }
	}

    //private void OnDestroy()
    //{
    //    Debug.Log("Player Died");
    //    gameOverPanel.SetActive(true);
    //}

    private void OnDisable()
    {
        Debug.Log("Player Died");
        this?.gameOverPanel?.SetActive(true);
    }
}