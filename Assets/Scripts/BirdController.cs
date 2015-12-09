using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax,yMin,yMax, zMin, zMax;
}

[RequireComponent(typeof(CharacterController))]
public class BirdController : MonoBehaviour {

	protected CharacterController control;
	public float speed;
	public float tilt;
	public Boundary boundary;
	public Component script;
	protected Vector3 move = Vector3.zero;

	public float moveSpeed = 3f;
	public float gravity = 9.81f *Time.deltaTime;
	// Use this for initialization
	public virtual void Start () {
		((FreeFlight)gameObject.GetComponent<FreeFlight>()).enabled = true;
		control = GetComponent<CharacterController> ();
		if (!control) {
			Debug.LogError ("Unit.start()" + name + " has no character controller!");
			enabled = false;
		}
	}
	
//	// Update is called once per frame
//	public virtual void Update () {
//		move.Normalize ();
//		control.SimpleMove(move * moveSpeed);
//		//control.Move( Vector3(x, gravity, z) );
//
//
//	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal,gravity, moveVertical);
		GetComponent<Rigidbody>().velocity = movement * speed;
		
		GetComponent<Rigidbody>().position = new Vector3 
			(
				Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), 
				Mathf.Clamp(GetComponent<Rigidbody>().position.y, boundary.yMin, boundary.yMax), 
				Mathf.Clamp (GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
		);
	}

}
