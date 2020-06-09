using UnityEngine;
using System.Collections;
//using UnityEngine.Diagnostics;


/* Code inspired by Unity's Playground "ObjectShooter" code 
and this YouTube video: https://www.youtube.com/watch?v=_Z1t7MNk0c4*/

public class ObjectShooter : MonoBehaviour
{
	[Header("Object creation")]
	
	public GameObject linearShotSpike;
    public GameObject circularShotSpike;

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
        if (!player)
            return;

		if (timeBtwShots <= 0) {
            // depending on the value of state, the boss will either do a linear shot, or shoot in a circular direction
            if(state <= 10f)
            {
                Instantiate(linearShotSpike, transform.position, Quaternion.identity);
            }
			else if(state >= 10f) // this should be state <= 2f, this is just to test code
            {
                for (int i = 0; i < 360; i+=30)
                {
                    Instantiate(circularShotSpike, transform.position, Quaternion.Euler(new Vector3(0f, 0f, i)));
                }
            }
            
            // can add more states such as spawning smaller enemies
            state += 2f; // increment state here
            if (state > 15f)
                state = 0;

            timeBtwShots = startTimeBtwShots;
        }
        else {
			timeBtwShots -=Time.deltaTime;
		}

	}
}
