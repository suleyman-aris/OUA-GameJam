using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance; // Tek bir GameManager örneði oluþturulur

    public int health = 3;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        Debug.Log("HealthManager" + health);
    }

    // Can sayýsý güncellendiðinde çaðrýlýr
    public void UpdateHealth(int newHealth)
    {
        health = newHealth;
    }

    // Can sayýsý dýþarýdan okunabilir hale getirilir
    public int GetHealth()
    {
        return health;
    }
}
