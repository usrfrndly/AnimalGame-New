using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody rigidb;
	// Public variables will show up in inspector
	public float speed;
	// Use this for initialization

	private int count;

	public Text countText;

	public Text winText;

	void Start () {
		//so we can access the rigidbody of player component
		rigidb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}
	
	// Update is called once per frame. Most game code.
	void Update () {
	
	}
	// Called before performing any physics calculation. 
	// We will be moving ball by performing calls on rigid body
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		// determines direction of the force that we will add to our ball
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rigidb.AddForce (movement * speed);
	
	}
	

	void OnTriggerEnter(Collider other) {
		//deactivate the gameobject that the collider is attached to
		if (other.gameObject.CompareTag ("Pickup")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText();
		}

	}

	void SetCountText(){
		countText.text = "Count: " + count.ToString ();
		if (count >= 10) {
			winText.text = "You win!";
		}
	}
}

