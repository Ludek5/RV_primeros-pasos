using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MenuController_naves : MonoBehaviour
{
    private Camera xRCamera;
    // Start is called before the first frame update
    void Start()
    {
        //xRCamera = CameraPointerManager.Instance.gameObject.GetComponent<Camera>(); //llamamos aquí a la clase CameraPointerManager como instance en UIElements; 
    }

    public void menu_principal()
    {
        SceneManager.LoadScene("Menu_principal");
    }

    public void reiniciar()
    {
        SceneManager.LoadScene("Juego_principal_vr");
    }

    public void game_over()
    {
        SceneManager.LoadScene("Menu Game Over");
    }

    /*public void OnPointerClick2D()
    {
        PointerEventData pointerEvent = PlacePointer();//Este es el elemento que nos permitira hacer clic sobre el elemento UI
                                                       //pero para ello se necesita una posición la cual esta en la función PlacePointer
        ExecuteEvents.Execute(this.gameObject, pointerEvent, ExecuteEvents.pointerClickHandler); //Executamos el evento al hacer clic;
    }

    public PointerEventData PlacePointer()
    {
        Vector2 screenPos = xRCamera.WorldToScreenPoint(CameraPointerManager.Instance.hitPoint);
        var pointer = new PointerEventData(EventSystem.current);
        pointer.position = new Vector2(screenPos.x, screenPos.y);
        return pointer;
    }*/
}
