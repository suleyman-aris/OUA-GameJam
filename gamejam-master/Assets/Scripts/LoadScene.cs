using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("Player") && Input.GetKey(KeyCode.UpArrow))
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; // Aktif sahnenin index numarasýný al
            int nextSceneIndex = currentSceneIndex + 1;
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
