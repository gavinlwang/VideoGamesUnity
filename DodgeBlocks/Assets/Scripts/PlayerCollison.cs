using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    public Rigidbody rb;
    public Playermovement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Invoke("stop", 1f);
        }
    }

    void stop ()
    {
        rb.constraints = RigidbodyConstraints.FreezePosition;
        FindObjectOfType<GameManager>().EndGame();
    }

}
