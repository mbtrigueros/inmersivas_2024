using UnityEngine;

public class BodyFollowHead : MonoBehaviour
{
   public Transform head;  // Reference to the camera/head transform

    void Update()
    {
        // Ensure the character's position is always aligned with the head (camera)
        transform.position = head.position;
        transform.rotation = head.rotation;  // Optional: Make sure rotation matches
    }
}
