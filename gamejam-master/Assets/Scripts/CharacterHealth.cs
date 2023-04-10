using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterHealth : MonoBehaviour
{
    public int health = 3; // Karakterin baþlangýçta 3 caný var

    private void Awake()
    {
        health = HealthManager.instance.health;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--; // Canavarlara çarptýðýnda bir canýný kaybeder
            if (health == 0)
            {
                Debug.Log("Game Over");
                SceneManager.LoadScene("GameOver");
                // Karakter öldüðünde yapýlacak iþlemler buraya yazýlabilir
            }

            else
            {
                Debug.Log(health);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Sahne tekrar yüklendiðinde
                // Karakterin can sayýsý doðru bir þekilde güncellenir
                HealthManager.instance.UpdateHealth(health);
            }
        }
    }
}
