using UnityEngine;
using System.Collections;

public class CameraRunnerScript : MonoBehaviour {

	public Transform follow;

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (follow.position.x + 6, 0, -10);
	}
}
