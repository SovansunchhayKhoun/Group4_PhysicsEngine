using UnityEngine;

public class SpringBallDrop : MonoBehaviour
{
    public Vector3 targetLocation = new Vector3(0, 0, 0);  // The location where the ball will be pulled
    private SpringJoint springJoint;
    private Rigidbody rb;

    void Start() 
    {
        // Get references to the Rigidbody and Spring Joint
        rb = GetComponent<Rigidbody>();
        springJoint = GetComponent<SpringJoint>();

        // Set the initial position of the ball
        transform.position = new Vector3(0, 5, 0);  // Start higher than the ground

        // Set the connected anchor point to the target location
        springJoint.connectedAnchor = targetLocation;

        // Optional: Adjust spring parameters dynamically if needed
        springJoint.spring = 10f;  // Strong spring to pull the ball
        springJoint.damper = 0f;    // Smooth damping effect

        // The Rigidbody should have gravity enabled by default (check it in the Inspector)
        // So no need to add any force manually to make it fall
    }

    void Update()
    {
        // Optional: You can dynamically adjust the spring or force parameters
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Change spring behavior during gameplay (for example)
            springJoint.spring = 50f;
        }
    }
}
