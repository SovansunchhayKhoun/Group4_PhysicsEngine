using UnityEngine;

public class CameraFollower : MonoBehaviour
{
  public float FollowSpeed = 2f;
  public Transform target;

  public void Start()
  {

  }

  public void LateUpdate()
  {
    Vector3 offset = new Vector3(-1.4f, 1.6f, -1f);
    transform.position = target.transform.position + offset;
  }
}
