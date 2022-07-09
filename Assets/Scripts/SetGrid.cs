using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGrid : MonoBehaviour
{
    [SerializeField] int columns = 5;
    [SerializeField] int rows = 5;
    [Space]
    [SerializeField] Transform startPoint;
    [Space]
    [SerializeField] GameObject groundPrefab;
    [SerializeField] float groundWidth = 1;

    private void Start()
    {
        SetMap();
    }

    void SetMap()
    {
        for (int a = 0; a < columns; a++)
        {
            for (int b = 0; b < rows; b++)
            {
                var soil = Instantiate(groundPrefab, startPoint.position + (Vector3.right * groundWidth * a) + (Vector3.forward * groundWidth * b), Quaternion.identity);
                soil.transform.parent = startPoint;
            }
        }
    }
}