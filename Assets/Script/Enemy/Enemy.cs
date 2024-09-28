using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    float leftBound;
    float rightBound;
    float objectWidth;
    float respawnDistance = 5f;

    private void Start()
    {
        Camera mainCamera = Camera.main;
        float screenHeight = mainCamera.orthographicSize * 2;
        float screenWidth = screenHeight * mainCamera.aspect;

        leftBound = mainCamera.transform.position.x - screenWidth / 2;
        rightBound = mainCamera.transform.position.x + screenWidth / 2;

        objectWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        if (!GameManger.instance.isAttacking)
        {
            speed = GameManger.instance.playerData.Speed * 2f;
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            if (transform.position.x + objectWidth / 2 < leftBound - respawnDistance)
            {
                Vector3 newPosition = new Vector3(rightBound + objectWidth / 2 + respawnDistance, transform.position.y, transform.position.z);
                transform.position = newPosition;
            }
        }
        
    }
}
