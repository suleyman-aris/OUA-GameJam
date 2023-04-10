using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance; // Tek bir GameManager �rne�i olu�turulur

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

    // Can say�s� g�ncellendi�inde �a�r�l�r
    public void UpdateHealth(int newHealth)
    {
        health = newHealth;
    }

    // Can say�s� d��ar�dan okunabilir hale getirilir
    public int GetHealth()
    {
        return health;
    }
}
