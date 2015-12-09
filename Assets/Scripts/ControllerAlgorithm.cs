using UnityEngine;
using System.Collections;

public class ControllerAlgorithm : MonoBehaviour
{
    //Animal Selected on Runtime
    public enum Animals { KANGAROO, PINGEON, COCKROACH, CAT, FISH }

    // Protected FIELDS.
    protected Rigidbody myRigibody; // To get the rigibody component attached.
    protected float moveVertical, moveHorizontal; //To obtain my Axis input.
    protected bool isGrounded = true; // Able to move if I'm on the floor or any Object that I can stand up.
    protected float gravityScale = 100f; // How fast I will fall once I jump.

    //PUBLIC FIELDS.
    public Animals animal = Animals.KANGAROO; //Default Setting ( Change on editor in order to get anything else by default)
    public Transform endPoint, startPoint; // object to check if I'm grounded.
    public LayerMask FloorLayer; // Layer of the Floor or Any Object that I can stand up.
    public float moveSpeed = 30f; // My movement speed.
    public float jumpHeight = 100f; // How high I can jump.
    public float rotateSpeed = 45f; // My rotation speed: How far i will look to other side.  

    //----------- KANGAROO CONTROLLER -----------
    public void KangarooController()
    {
        //Move forward if > 0 or backward if < 0
        if (moveVertical > 0)
            myRigibody.velocity = transform.forward * moveSpeed;

        if (moveVertical < 0)
            myRigibody.velocity = -transform.forward * moveSpeed;

        //Jump
        if (moveVertical > 0 || moveVertical < 0)
            myRigibody.velocity = new Vector3(myRigibody.velocity.x, jumpHeight, myRigibody.velocity.z);
    }//kangaroo

    //----------- PINGEON CONTROLLER -----------
    public void PingeonController()
    {
        // If is not on the ground will keep moving/flying
        if (!isGrounded)
            myRigibody.velocity = transform.forward * moveSpeed;

        //Rotate on X-Axis when (W-A, UP_ARROW-DOWN_ARROW) keys are pressed
        if (moveVertical < 0)
            transform.Rotate(new Vector3(-rotateSpeed * Time.deltaTime, 0, 0));

        if (moveVertical > 0)
            transform.Rotate(new Vector3(rotateSpeed * Time.deltaTime, 0, 0));

        //Jump Input
        if (Input.GetKey(KeyCode.LeftShift))
            myRigibody.velocity = new Vector3(myRigibody.velocity.x, jumpHeight, myRigibody.velocity.z);
    }//kangaroo

    //----------- COCKROACH CONTROLLER -----------
    public void CockroachController()
    {
        //Move forward if > 0 or backward if < 0
        if (moveVertical > 0)
            myRigibody.velocity = transform.forward * moveSpeed;

        if (moveVertical < 0)
            myRigibody.velocity = -transform.forward * moveSpeed;
    }//kangaroo

    //----------- CAT CONTROLLER -----------
    public void CatController()
    {
        //Move forward if > 0 or backward if < 0
        if (moveVertical > 0)
            myRigibody.velocity = transform.forward * moveSpeed;

        if (moveVertical < 0)
            myRigibody.velocity = -transform.forward * moveSpeed;

        //Jump Input
        if (Input.GetKey(KeyCode.LeftShift))
            myRigibody.velocity = new Vector3(myRigibody.velocity.x, jumpHeight, myRigibody.velocity.z);
    }//kangaroo

    //----------- FISH CONTROLLER -----------
    public void FishController()
    {
        //Move forward if > 0 or backward if < 0
        if (moveVertical > 0)
            myRigibody.velocity = transform.forward * moveSpeed;
    }//kangaroo

}//class
