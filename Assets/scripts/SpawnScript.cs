using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;

	void Start () {
		spawn ();
	}

	void spawn() {
		print (transform.position.ToString ());

		Instantiate (obj [Random.Range (0, obj.Length)], new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);

		Invoke ("spawn", Random.Range (spawnMin, spawnMax));
	}

}
