using UnityEngine;
using System.Collections;

public class CatController : MonoBehaviour {
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.AddForce(transform.forward * 100,ForceMode.Acceleration);
		}
	}

	void CatWalk (){

	}

}


