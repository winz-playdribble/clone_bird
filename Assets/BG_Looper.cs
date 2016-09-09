using UnityEngine;
using System.Collections;

public class BG_Looper : MonoBehaviour {
	int numBGPanels = 6;

	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log ("ColliderTriggered: " + collider.name);

		float withOfBGObject = ((BoxCollider2D)collider).size.x;
		Vector3 pos = collider.transform.position;
		pos.x += withOfBGObject * numBGPanels - withOfBGObject/2f;

		collider.transform.position = pos;
	}
}
