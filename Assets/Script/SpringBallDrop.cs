using UnityEngine;

public class SpringBallDrop : MonoBehaviour
{
    public Vector3 targetLocation = new Vector3(0, 0, 0);  // The location where the ball will be pulled
    private SpringJoint springJoint;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        springJoint = GetComponent<SpringJoint>();
        transform.position = new Vector3(0, 5, 0);  // Start higher than the ground
        springJoint.connectedAnchor = targetLocation;
        springJoint.spring = 10f;  // Strong spring to pull the ball
        springJoint.damper = 0f;    // Smooth damping effect
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            springJoint.spring = 50f;
        }
    }
}