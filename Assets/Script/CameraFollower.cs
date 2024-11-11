using UnityEngine;

public class CameraFollower : MonoBehaviour
{
  public float FollowSpeed = 2f;
  public Transform target;

  public void Start()
  {
    // transform.Rotate(45f, transform.rotation.y, transform.rotation.z);
  }

  public void LateUpdate()
  {
    transform.position = target.transform.position + new Vector3(-1.53f, 2f, 1.5f);
  }
}
