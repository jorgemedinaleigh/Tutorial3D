using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    public PlayerMovement movimiento;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("Hit");
            movimiento.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
