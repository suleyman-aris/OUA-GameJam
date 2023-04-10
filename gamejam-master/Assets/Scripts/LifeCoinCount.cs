using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCoinCount : MonoBehaviour
{
    public Text lifeText;
    //public Text CoinText;

    private int coinCounter;

    private void Start()
    {
        
        int life = GameObject.Find("boy1").GetComponent<CharacterHealth>().health;
        lifeText.text = "Life : " + life.ToString();
    }
    
    public void CountCoin()
    {
        coinCounter++;
    
    }
}
