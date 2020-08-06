using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private GameObject virus;

    private int virusCount;

    private void Generatevirus()
    {
        
        Vector2 spawnpoint;
        Bounds cordenadas = spriteRenderer.bounds;

        spawnpoint = new Vector2(Random.Range(cordenadas.min.x, cordenadas.max.x), Random.Range(cordenadas.min.y, cordenadas.max.y));

        GameObject  virusclone = Instantiate(virus, spawnpoint, Quaternion.identity);
    }

    void Update()
    {
        if (virusCount < 100)
        {
            Generatevirus();
            virusCount++;

        }

    }

}
