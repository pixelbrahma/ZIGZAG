using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathGeneration : MonoBehaviour {
    public static int direction;
    private int distance;
    [SerializeField] private Transform pathPrefab;
    private GameObject player;
    private Vector3 position;

    private void Start()
    {
        player = GameObject.Find("Player");
        direction = 0;
        distance = Random.Range(3, 6);
        position = transform.position + new Vector3(distance / 2, 0f, 0f);
        Transform first = Instantiate(pathPrefab, position, Quaternion.identity);
        first.transform.localScale = new Vector3(distance, 1f, 1f);
    }

    private void Update()
    {
        if (position.x - player.transform.position.x < 5)
            GenerateNext();
    }

    private void GenerateNext()
    {
        if (direction == 0)
            position += new Vector3(distance / 2, 0f, 0f);
        else
            position += new Vector3(0f, distance / 2, 0f);
        if (direction == 0)
            direction = 1;
        else
            direction = 0;
        distance = Random.Range(3, 6);
        if (direction == 0)
            position += new Vector3(distance / 2, 0f, 0f);
        else
            position += new Vector3(0f, distance / 2, 0f);
        Transform path = Instantiate(pathPrefab, position, Quaternion.identity);
        if (direction == 0)
            path.transform.localScale = new Vector3(distance, 1f, 1f);
        else
            path.transform.localScale = new Vector3(1f, distance, 1f);
    }
}