using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public bool isGameStarted = false;
    float elapsedTime = 3;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    private void Update()
    {
        elapsedTime -= Time.deltaTime;

        if (elapsedTime > 0)
            return;
        else
        {
            StartGame();
        }
    }
    private void StartGame()
    {
        isGameStarted = true;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
