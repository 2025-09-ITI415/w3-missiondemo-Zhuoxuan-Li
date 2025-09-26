using UnityEngine;

public class Wall : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
 
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Debug.Log("The wall was hit! Disappeared.");

            Destroy(gameObject);


        }
    }
}
