using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Ejercicio03 - pinpong");
    }

    public void Salir()
    {
        Application.Quit(); 
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
#endif
    }

    public void VolverAlMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

