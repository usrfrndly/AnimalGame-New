using UnityEngine;
using System.Collections;

public class CameraController1 : MonoBehaviour {
//	
//public GameObject catCamera;
//public GameObject birdCamera;
//public GameObject kangarooCamera;
////
//	public BirdController birdInput;
//	public KangarooController kangarooInput;
//	public CatController catInput;
//
//	public bool catActive = true;
//	public bool birdActive = false;
//	public bool kangarooActive = false;
////
//	public GameObject defaultCamera;
//	public GameObject catCamera;
//	public GameObject birdCamera;
//	public GameObject kangarooCamera;
//
//	public 
////
////
////
//	void Start(){
//		birdInput = (BirdController) bird.GetComponent("BirdController");
//		kangarooInput = (KangarooController) kangaroo.GetComponent("KangarooController");
//		catInput = (CatController)cat.GetComponent ("CatController");
//
//
//	}
////	
////	
////	
//	void Update(){
//		if(Input.GetKeyDown(KeyCode.Keypad1))  {
//			print("1 key was pressed");
//
//			catActive = true;
//			birdActive = false;
//			kangarooActive = false;
//		}
//		
//		if(Input.GetKeyDown(KeyCode.Keypad2))  {
//			print("2 key was pressed");
//
//			catActive = false;
//			birdActive = true;
//			kangarooActive = false;
//		}
//
//		if(Input.GetKeyDown(KeyCode.Keypad3))  {
//			print("3 key was pressed");
//			
//			catActive = false;
//			birdActive = false;
//			kangarooActive = true;
//		}
//		
//		if(catActive){
//			switchToPlayer(catInput, birdInput, kangarooInput, cameraPlayer1);  
//		}
//		
//		if(player2Active){
//			switchToPlayer(player2Input, player1Input, cameraPlayer2);  
//		}
//		
//	}
////	
//	void switchToPlayer(CharacterController inputToEnable, CharacterController inputToDisable, GameObject cameraLocation){
//		
//		inputToEnable.enabled = true;
//		
//		inputToDisable.enabled = false;
//		
//		defaultCamera.transform.position = cameraLocation.transform.position; //Consider lerping 
//		
//		defaultCamera.transform.rotation = cameraLocation.transform.rotation; //Consider lerping
//	}
//
//
//	public Camera cam1;
//	public Camera cam2;
//	public Camera cam3;
//
//	void Start() {
//		cam3.enabled = true;
//		//cam2.enabled = false;
//		cam1.enabled = false;
//	}
//	void Update()
//	{
//		if (Input.GetKeyDown(KeyCode.C)) {
//			cam1.enabled = !cam1.enabled;
//			//cam2.enabled = !cam2.enabled;
//			cam3.enabled = !cam3.enabled;
//
//		}
//	}


	private GameObject currentCharacter;
	
	private GameObject catPlayer;
	private GameObject birdPlayer;
	private GameObject kangarooPlayer;
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
		if (Input.GetKeyDown (KeyCode.Alpha0)) {
			print ("0 key was pressed");
			currentCharacter = catPlayer;
			catCamera.enabled = true;
			currentCharacter.SetActive (true);
			
			birdPlayer.SetActive (false);
			kangarooPlayer.SetActive (false);
			kangarooCamera.enabled = false;
			birdCamera.enabled = false;
			
			
		}
		
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			print ("1 key was pressed");
			currentCharacter = kangarooPlayer;
			birdPlayer.SetActive (false);
			birdCamera.enabled = false;
			
			catPlayer.SetActive (false);
			catCamera.enabled = false;

			currentCharacter.SetActive (true);
			kangarooCamera.enabled = true;
			
	
		}
		
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			print ("2 key was pressed");
			currentCharacter = birdPlayer;

			
			catPlayer.SetActive (false);
			catCamera.enabled = false;
			
			kangarooPlayer.SetActive (false);
			kangarooCamera.enabled = false;
			birdCamera.enabled = true;
			currentCharacter.SetActive (true);
		}
	}

}