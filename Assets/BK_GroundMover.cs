using UnityEngine;
using System.Collections;

public class BK_GroundMover : MonoBehaviour {

	float speed = 1.4f;
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
	}
}
