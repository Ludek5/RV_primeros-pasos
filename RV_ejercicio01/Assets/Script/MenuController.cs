using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Ejercicio03 - pinpong");
    }

    public void Opciones()
    {
        Debug.Log("Opciones");
    }
    
    public void Salir()
    {
        Application.Quit(); 
    }
}

