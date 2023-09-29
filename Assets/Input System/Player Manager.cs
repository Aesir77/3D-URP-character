using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance { get; private set; } 
    public GameObject player; 
    public PlayerLocomotion playerLocomotion;
    public InputManager inputManager;
    public float movementspeed; 
    public Rigidbody rb;
    // Start is called before the first frame update


    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        } else
        {
            instance = this;
        }
    }
    void Start()
    {
        playerLocomotion = player.GetComponent<PlayerLocomotion>();
        inputManager = player.GetComponent<InputManager>();
        Rigidbody = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputManager.HandleAllInput(); 
    }

    private void FixedUpdate()
    {
        playerLocomotion.HandlesAllMovement();
    }
}
