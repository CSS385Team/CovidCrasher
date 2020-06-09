using UnityEngine;
using System.Collections;
//using UnityEngine.Diagnostics;


/* Code inspired by Unity's Playground "ObjectShooter" code 
and this YouTube video: https://www.youtube.com/watch?v=_Z1t7MNk0c4*/

public class ObjectShooter : MonoBehaviour
{
	[Header("Object creation")]
	
	public GameObject prefabToSpawn;

	public Transform player;

	// The key to press to create the objects/projectiles
	//public KeyCode keyToPress = KeyCode.Space;

	[Header("Other options")]

	private float timeBtwShots;
	public float startTimeBtwShots = 1f;
    private float state = 0f;  // this variable keeps track of what attacks the boss will do as time progresses

	// Use this for initialization
	void Start ()
	{
		//timeOfLastSpawn = -creationRate;
		player = GameObject.FindGameObjectWithTag("Player").transform;

		timeBtwShots = startTimeBtwShots;
	}


	// Update is called once per frame
	void Update ()
	{
		if (timeBtwShots <= 0) {
            // depending on the value of state, the boss will either do a linear shot, or shoot in a circular direction
            if(state <= 1f)
            {
                Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
                timeBtwShots = startTimeBtwShots;
            }
			else if(state >= 1f) // this should be state <= 2f, this is just to test code
            {   
                Instantiate(prefabToSpawn, transform.position, Quaternion.Euler(new Vector3(0f, 0f, 90f))); // straight shot
                Instantiate(prefabToSpawn, transform.position, Quaternion.Euler(new Vector3(0f, 0f, 120f))); // slightly upwards
                Instantiate(prefabToSpawn, transform.position, Quaternion.Euler(new Vector3(0f, 0f, 60f))); // slightly downwards
            }
            // can add more states such as spawning smaller enemies
            state += 0.5f; // increment state here
		} else {
			timeBtwShots -=Time.deltaTime;
		}

	}
}
