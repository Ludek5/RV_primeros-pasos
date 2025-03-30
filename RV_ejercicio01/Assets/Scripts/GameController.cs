using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{

    public Player player;
    public Ball ball;
    public TextMeshProUGUI scoreText;
    [SerializeField] Canvas canvas;

    private float gameOverTimer = 3f;

    void Start() {

    }

    void Update()
    {
        bool isGameOver = ball.transform.position.z < player.transform.position.z;

        if (isGameOver == false)
        {
            scoreText.text = "Score: " + ball.score;
        } else {
            scoreText.text = "Game over!\nYour final score: " + ball.score;
            canvas.gameObject.SetActive(true);
        }
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu"); 
    }
}
