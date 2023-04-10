using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterHealth : MonoBehaviour
{
    public int health = 3; // Karakterin ba�lang��ta 3 can� var

    private void Awake()
    {
        health = HealthManager.instance.health;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--; // Canavarlara �arpt���nda bir can�n� kaybeder
            if (health == 0)
            {
                Debug.Log("Game Over");
                SceneManager.LoadScene("GameOver");
                // Karakter �ld���nde yap�lacak i�lemler buraya yaz�labilir
            }

            else
            {
                Debug.Log(health);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Sahne tekrar y�klendi�inde
                // Karakterin can say�s� do�ru bir �ekilde g�ncellenir
                HealthManager.instance.UpdateHealth(health);
            }
        }
    }
}
