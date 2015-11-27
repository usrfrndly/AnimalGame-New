using UnityEngine;
using System.Collections.Generic;

public class ButtonSwapScript : MonoBehaviour
{
    public GameObject currentAnimal;

    public void SpawnAnimal(GameObject animal)
    {
        currentAnimal = GameObject.FindGameObjectWithTag("Player");

        if (currentAnimal == null)
            Instantiate(animal, transform.position, Quaternion.identity);

        else
        {
            Destroy(currentAnimal);
            Instantiate(animal, transform.position, Quaternion.identity);
        }
    }//Spawn Function

}//class
