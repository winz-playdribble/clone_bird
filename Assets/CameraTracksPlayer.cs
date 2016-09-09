﻿using UnityEngine;
using System.Collections;

public class CameraTracksPlayer : MonoBehaviour {

	Transform player;

	float offSetX;

	// Use this for initialization
	void Start () {
		GameObject playerTemp = GameObject.FindGameObjectWithTag("Player");

		if(playerTemp != null){
			player = playerTemp.transform;
		}

		offSetX = transform.position.x - player.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		if(player != null){
			Vector3 pos = transform.position;
			pos.x = player.position.x + offSetX;
			transform.position = pos;
		}
	}
}
