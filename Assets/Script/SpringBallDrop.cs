using UnityEngine;
using UnityEngine.UI;

public class SpringBallDrop : MonoBehaviour
{
    public Vector3 targetLocation = new Vector3(-7 , 3, -4);  
    public Transform anchorPoint;  
     private SpringJoint springJoint;
    private Rigidbody rb;
    private LineRenderer lineRenderer;  
    private float countdown = 3f;  
    private bool isCountingDown = true;

    void Start()
    {
         rb = GetComponent<Rigidbody>();
        springJoint = GetComponent<SpringJoint>();

      
        if (anchorPoint == null)
        {
            GameObject anchorObject = new GameObject("AnchorPoint");
            anchorPoint = anchorObject.transform;
            anchorPoint.position = new Vector3(-7, 6, -4);  
        }

        
        springJoint.connectedAnchor = anchorPoint.position;
 
        springJoint.spring = 10f;   
        springJoint.damper = 1f;   

        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.startWidth = 0.05f;  
        lineRenderer.endWidth = 0.05f;
        lineRenderer.positionCount = 2;  
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.startColor = Color.black; 
        lineRenderer.endColor = Color.black;
    }

    void Update()
    {
        if (isCountingDown)
        {
            countdown -= Time.deltaTime;
            if (countdown <= 0)
            {
                isCountingDown = false;
                CutString();
            }
        }
        if (lineRenderer != null)
        {
            lineRenderer.SetPosition(0, anchorPoint.position); 
            lineRenderer.SetPosition(1, transform.position);  
        }
    }
void CutString()
{
    if (springJoint != null)
    {
        Destroy(springJoint);
    }

    if (lineRenderer != null)
    {
        Destroy(lineRenderer);
    }
}
}