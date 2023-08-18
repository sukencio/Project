using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Velocidad de movimiento del personaje

    void Update()
    {
        // Obtener la entrada del teclado
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calcular el vector de movimiento
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * moveSpeed * Time.deltaTime;

        // Aplicar el movimiento al objeto del personaje
        transform.Translate(movement);
    }
}
