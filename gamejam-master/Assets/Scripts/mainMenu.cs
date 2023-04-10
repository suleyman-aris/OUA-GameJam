using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{
    public void playGame() // Oyunu başlatma fonksiyonu
    {
        SceneManager.LoadScene("Level1");
        /*-----> SAHNE AYARI YAPILIRKEN EN ÜSTTE BU SAHNEYİ KOYMAYI UNUTMA. <----*/
    }
    public void quitGame() // Oyunu kapatma fonksiyonu
    {
        Debug.Log("Oyundan Çıkıldı");
        Application.Quit();
    }
    public void creditScene() // Hazırlayanlar sahnesine geçiş
    {
        SceneManager.LoadScene("creditScene"); // Sahnenin adı değişirse burayı güncelle
    }

    public void settings()
    {
        SceneManager.LoadScene("settingsScene");
    }
    public void goMainMenu()
    {
        SceneManager.LoadScene("Level1");
    }
}
