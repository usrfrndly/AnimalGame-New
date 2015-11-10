using UnityEngine;
using System.Collections;

public class CameraControllerNew : MonoBehaviour {

	private GameObject currentCharacter;

	public GameObject catPlayer;
	public GameObject birdPlayer;
	public GameObject kangarooPlayer;
	//public List<GameObject> characterList = new List<GameObject>();

	public Camera catCamera;
	public Camera kangarooCamera;
	public Camera birdCamera;



	void Start(){

		catPlayer = GameObject.Find ("CatPlayer");
		birdPlayer = GameObject.Find ("BirdPlayer");
		kangarooPlayer = GameObject.Find ("KangarooPlayer");
		currentCharacter = catPlayer;
		catCamera.enabled = true;
		currentCharacter.SetActive (true);
		
		birdPlayer.SetActive (false);
		kangarooPlayer.SetActive (false);
		kangarooCamera.enabled = false;
		birdCamera.enabled = false;





//		foreach (GameObject character in allCharacters) {
//			characterList.Add (character);
//
//
//		}

	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Keypad0)) {
			print ("0 key was pressed");
			currentCharacter = catPlayer;
			catCamera.enabled = true;
			currentCharacter.SetActive (true);

			birdPlayer.SetActive (false);
			kangarooPlayer.SetActive (false);
			kangarooCamera.enabled = false;
			birdCamera.enabled = false;

		
		}
		
		if (Input.GetKeyDown (KeyCode.Keypad1)) {
			print ("1 key was pressed");
			currentCharacter = kangarooPlayer;
			currentCharacter.SetActive (true);
			kangarooCamera.enabled = true;

			birdPlayer.SetActive (false);
			birdCamera.enabled = false;

			catPlayer.SetActive (false);
			catCamera.enabled = false;
		}
		
		if (Input.GetKeyDown (KeyCode.Keypad2)) {
			print ("2 key was pressed");
			currentCharacter = birdPlayer;
			birdCamera.enabled = true;
			currentCharacter.SetActive (true);
			
			catPlayer.SetActive (false);
			catCamera.enabled = false;

			kangarooPlayer.SetActive (false);
			kangarooCamera.enabled = false;
		}



	}
}

