using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public void Regresar()
    {
        SceneManager.LoadScene("Ejercicio05 - naves");
    }
}
