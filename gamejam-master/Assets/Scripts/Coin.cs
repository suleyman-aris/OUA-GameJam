using UnityEngine;
using ScoreManagerSystem;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
    ScoreManager score = new ScoreManager();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CollectCoin();
        }
    }

    private void CollectCoin()
    {
        score.ChangeScore(coinValue);
        Destroy(gameObject);
    }
}
