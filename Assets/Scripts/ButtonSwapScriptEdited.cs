using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.EventSystems;
public class ButtonSwapScriptEdited : MonoBehaviour
{
    private GameObject currentAnimal;

	//public GameObject catPlayer;
	//public GameObject kangarooPlayer;
	//public Camera mainCamera;
	//public Camera kangarooCamera;
	//private GameObject[] animalList; 

	 //void Start(){
	//	animalList = GameObject.FindGameObjectsWithTag ("Player");
	//	catPlayer = GameObject.Find ("CatController");
	//	kangarooPlayer = GameObject.Find ("KangarooController");

		//catCamera.enabled = true;
		//catPlayer.SetActive (true);

		//currentAnimal = catPlayer;
//		for(int i = 0; i < animalList.Length; i++) {
//			if (!currentAnimal.Equals (animalList [i])) {
//				animalList [i].SetActive (false);
//				animalList [i].GetComponentInChildren<Camera>().enabled = false;
//			}
//		}
		//kangarooPlayer.SetActive (false);
		//kangarooCamera.enabled = false;


	//}

//	void Update(){
//	}

    public void SpawnAnimal(GameObject animal)
    {
		currentAnimal = animal;
//
//		for(int i = 0; i < animalList.Length; i++) {
//			if (!animal.Equals (animalList [i])) {
//				animalList [i].SetActive (false);
//				animalList [i].GetComponentInChildren<Camera>().enabled = false;
//			}
//		}
//		animal.SetActive (true);
//		animal.GetComponentInChildren<Camera> ().enabled = true;
//	}
//}
		GameObject cam = GameObject.Find ("Main Camera");

        if (currentAnimal == null) {
			GameObject animalclone = ((GameObject)Instantiate (animal, transform.position, Quaternion.identity));
			cam.transform.parent = animalclone.transform; 
			cam.GetComponentInChildren<StereoController>().UpdateStereoValues();
		}

        else
        {
            Destroy(currentAnimal);
			GameObject animalclone = ((GameObject)Instantiate(animal, transform.position, Quaternion.identity));
			cam.transform.parent = animalclone.transform;
			cam.GetComponentInChildren<StereoController>().UpdateStereoValues();

        }
    }//Spawn Function

}//class

