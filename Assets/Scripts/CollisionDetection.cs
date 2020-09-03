using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public PlayerMovement movement;
    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacles")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
