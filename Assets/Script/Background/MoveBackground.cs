using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveBackground : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float scrollDistance;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector3 moveDirection;

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
        
        if (transform.position.x <= -scrollDistance) transform.position = target.position - moveDirection * scrollDistance;
    }
}
