using UnityEngine;

public class Center : MonoBehaviour
{
    public ScoreAmount ScoreAmount;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
        {
            ScoreAmount.Instance.AddScore(1);
        }
    }
}
