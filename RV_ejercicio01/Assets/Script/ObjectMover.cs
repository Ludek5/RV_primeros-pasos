using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectMover : MonoBehaviour
{
    [SerializeField] private float moveDistance = 0.5f; // Distancia que se moverá el objeto en cada carga
    [SerializeField] private float moveSpeed = 2f;     // Velocidad del movimiento

    private Vector3 targetPosition;
    private bool isMoving = false;

    private void Start()
    {
        targetPosition = transform.position;
    }

    public void MoveRight()
    {
        if (!isMoving)
        {
            targetPosition += Vector3.right * moveDistance;
            StartCoroutine(MoveToTarget());
        }
    }

    private IEnumerator MoveToTarget()
    {
        isMoving = true;

        while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }

        transform.position = targetPosition; // Asegura que termine exactamente en la posición deseada
        isMoving = false;
    }
}

