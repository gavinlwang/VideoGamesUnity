using UnityEngine;

public class Fall : MonoBehaviour
{

    public Transform player;
    public Rigidbody rb;
    // Update is called once per frame
    void Update()
    {
        if (player.position.z < (transform.position.z - 261))
            rb.constraints = RigidbodyConstraints.FreezePosition;

        else
            rb.constraints = RigidbodyConstraints.None; 

    }
}
