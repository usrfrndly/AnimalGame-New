using UnityEngine;
using System.Collections;

public class PcPlayerController : ControllerAlgorithm
{
    // Use this for initialization
    /// <summary>
    /// Gravity Component: As we will use gravity to fall once we reach the max jump height, we have to make sure he fall on the right speed that fit our needs.
    /// </summary>
    void Start()
    {
        //Getting My Rigibody Component.
        myRigibody = GetComponent<Rigidbody>();

        // If we falling on Y-Axis, change gravityScale to X value or Z value if we are falling on those Axis.
        // Only pingeon need to have 0 gravity.
        if (animal == Animals.PINGEON)
            Physics.gravity = new Vector3(0, 0, 0);
        else
            Physics.gravity = new Vector3(0, gravityScale * -1, 0);
    }//Start Function

    /// <summary>
    // Raycasting to check if we are on ground, so we can jump. 
    // Moving and Jumping Behaviour.
    /// </summary>
    // FixedUpdate is called every frame (Constant Interaction)
    void FixedUpdate()
    {
        nullExceptionHandler();
        raycasting();
        moveOnInput();
    }//Update Function

    // Moving and Jumping Behaviour.
    private void moveOnInput()
    {
        //Get Axis input
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        //Rotate on Y-Axis only
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0));

        // Animals that only can move and jump if is grounded      
        if (isGrounded)
        {
            // Select the controller depending on which one you selected on editor (Kangaroo is the default selection).
            if (animal == Animals.KANGAROO)
                KangarooController();

            if (animal == Animals.COCKROACH)
                CockroachController();

            if (animal == Animals.CAT)
                CatController();
        }// IF- isGrounded

        // Flying or floating animals that can move without being grounded.
        if (animal == Animals.PINGEON)
            PingeonController();

        if (animal == Animals.FISH)
            FishController();
    }// Controller Function

    // Raycasting to check if we are on ground, so we can jump. 
    private void raycasting()
    {
        isGrounded = Physics.Linecast(startPoint.position, endPoint.position, FloorLayer);
    }//raycasting Function

    // just handling exception, please remember to add theses objects (startPoint, endPoint) to the script component.
    private void nullExceptionHandler()
    {
        if (endPoint == null)
            endPoint = GameObject.Find("endPoint").transform;

        if (startPoint == null)
            startPoint = GameObject.Find("startPoint").transform;

        if (endPoint == null)
        {
            Debug.LogError("Left Point Object reference is missing!, Please drag the children Object called 'leftPoint' to the Script attached to the Player.");
            return;
        }
        if (startPoint == null)
        {
            Debug.LogError("Right Point Object reference is missing!, Please drag the children Object called 'rightPoint' to the Script attached to the Player.");
            return;
        }
    }// Exception Error Handler

    //Visual reference
    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(startPoint.position, endPoint.position);
    }// visual reference - Gizmos
}//class
