using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
   private Vector3 movedirection;
    Transform cameraObject;

    public void HandlesAllMovement()
    {
        HandlesRotation();
        HandlesMovement();
    }
    private void HandlesRotation()
    {

    }
    private void HandlesMovement()
    {
        movedirection = cameraObject.forward * PlayerManager.instance.inputManager.verticalInput;
        movedirection += cameraObject.right * PlayerManager.instance.inputManager.horizontalInput;
        movedirection.Normalize();
        movedirection.y = 0;
        movedirection = movedirection * PlayerManager.instance.movementspeed;
        Vector3 movementVelocity = movedirection;
        PlayerManager.instance.rb.velocity = movementVelocity;
    }

    // Start is called before the first frame update
    void Start()
    {
        cameraObject = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
