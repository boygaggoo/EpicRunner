using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Player") {
			Application.LoadLevel("gameover");
			return;
		}

		if(other.gameObject.transform.parent != null) {
			Destroy (other.gameObject.transform.parent.gameObject);
		}
	}
}
