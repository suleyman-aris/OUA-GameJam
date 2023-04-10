using UnityEngine;

namespace ScoreManagerSystem
{

    public class ScoreManager : MonoBehaviour
    {
        public static ScoreManager instance;
        LifeCoinCount lifeCoinCount = new LifeCoinCount();

        private int currentScore ;

        private void Start()
        {
            //lifeCoinCount = GameObject.Find("UIController").GetComponent<LifeCoinCount>();
            lifeCoinCount = FindObjectOfType<LifeCoinCount>();
        }

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void ChangeScore(int amount)
        {
            currentScore += amount;
            if (lifeCoinCount != null)
            {
                lifeCoinCount.CountCoin();
            }
            Debug.Log("Current Score: " + currentScore);
        }
    }
}