using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	//Transform value of camera - transform value of the player
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	
	}
	
	// LateUpdate is called once per frame and after all information has been recorded
	void LateUpdate () {
		//always aligned with player
		transform.position = player.transform.position + offset;
	
	}
	// For follow camera, gathering procedureal info, and last 
}

