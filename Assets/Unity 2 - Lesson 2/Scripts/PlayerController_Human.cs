using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController_Human : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10f;
    public GameObject projectilePrefab;
    public float projectileHeight = 1.0f;
    void Update()
    {
        // Keep the player in bounds
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // Clamp the player's position
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -xRange, xRange);
        transform.position = clampedPosition;

        // Check for shooting input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Disparar();
        }
    }
        void Disparar()
        {
            Vector3 spawnPosition = transform.position + Vector3.up * projectileHeight;
            Instantiate(projectilePrefab, spawnPosition, Quaternion.identity);
        }
}

