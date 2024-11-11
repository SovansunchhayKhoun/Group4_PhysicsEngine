using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartGameScene()
    {
        SceneManager.LoadScene("MainGameScene");  // Replace "MainGameScene" with your actual game scene name
    }
}
