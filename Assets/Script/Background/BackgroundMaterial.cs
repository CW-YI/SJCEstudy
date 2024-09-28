using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMaterial : MonoBehaviour
{
    [SerializeField] [Range(-1.0f, 1.0f)]
    private float moveSpeed = 0.1f;
    private Material material;

    private Vector2 currentOffset = Vector2.zero;

    private void Awake()
    {
        material = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        if (!GameManger.instance.isAttacking)
        {
            currentOffset += Vector2.right * moveSpeed * Time.deltaTime * (GameManger.instance.playerData.Speed);
            material.SetTextureOffset("_MainTex", currentOffset);
        }

        }
    }
