using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public Transform shootPoint;
    public float shootInterval;
    public float shootTimer;
    public int points;
    void Update()
    {
        Move();
        Shoot();
        shootTimer -= Time.deltaTime;
    }

    private void Move()
    {
        if(Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = realPos;
        }
    }

    public Projectile projectilePrefab;

    void Shoot()
    {

        if(shootTimer <= 0)
        {
            Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            shootTimer = shootInterval;
        }
    }
}
