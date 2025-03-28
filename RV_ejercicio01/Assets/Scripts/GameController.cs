using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Player player;
    public Ball ball;
    public TextMesh scoreText;

    public GameObject gameOverPanel;
    public Button btnReiniciar;     
    public Button btnMenu;          

    private bool isGameOver = false;

    void Start()
    {
        gameOverPanel.SetActive(false);

        btnReiniciar.onClick.AddListener(ReiniciarJuego);
        btnMenu.onClick.AddListener(RegresarAlMenu);
    }

    void Update()
    {
        if (!isGameOver)
        {
            isGameOver = ball.transform.position.z < player.transform.position.z;
            if (!isGameOver)
            {
                scoreText.text = "Score: " + ball.score;
            }
            else
            {
                scoreText.text = "Game over!\nYour final score: " + ball.score;
                gameOverPanel.SetActive(true); 
            }
        }
    }

    void ReiniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void RegresarAlMenu()
    {
        SceneManager.LoadScene("Menu"); 
    }
}
