using UnityEngine;
using UnityEngine.SceneManagement;

public class AddScoreOnHit : MonoBehaviour
{
    public int points = 100;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Projectile"))
        {
            ScoreManager.Instance.AddScore(points);
            Destroy(gameObject);
        }
    }
}

