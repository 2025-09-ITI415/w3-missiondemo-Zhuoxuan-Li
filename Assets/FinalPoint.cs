using UnityEngine;

public class AddScoreOnTrigger : MonoBehaviour
{
    public int points = 250;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile")) 
        {
            ScoreManager.Instance.AddScore(points);


        }
    }
}
