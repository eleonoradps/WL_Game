using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropShape : MonoBehaviour
{

    [SerializeField] GameObject squarePrefab;
    [SerializeField] GameObject circlePrefab;
    [SerializeField] GameObject trianglePrefab;
    [SerializeField] GameObject linePrefab;

    public void InstantiateSquare()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(squarePrefab);
        }
    }

    public void InstantiateCircle()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(circlePrefab);
        }
    }

    public void InstantiateTriangle()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(trianglePrefab);
        }
    }

    public void InstantiateLine()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(linePrefab);
        }
    }
}
