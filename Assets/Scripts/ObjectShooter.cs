using UnityEngine;
using System.Collections;
//using UnityEngine.Diagnostics;


/* Code inspired by Unity's Playground "ObjectShooter"
code and this YouTube video: https://www.youtube.com/watch?v=_Z1t7MNk0c4*/

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
			Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
			timeBtwShots = startTimeBtwShots;
		} else {
			timeBtwShots -=Time.deltaTime;
		}

	}
}
