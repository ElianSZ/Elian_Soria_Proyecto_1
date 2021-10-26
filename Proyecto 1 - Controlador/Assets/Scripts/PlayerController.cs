using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Velocidad
    private float speed = 15;

    // Velocidad de giro
    private float turnSpeed = 40;

    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Movimiento hacia delante
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Movimiento lateral
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        // Rotación
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
