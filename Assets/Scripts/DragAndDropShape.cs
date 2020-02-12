using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropShape : MonoBehaviour
{
    //[SerializeField] GameObject squarePrefab;
    //[SerializeField] GameObject circlePrefab;
    //[SerializeField] GameObject trianglePrefab;
    //[SerializeField] GameObject linePrefab;

    private bool draggingShape = true;
    private float distance;
    [SerializeField] GameObject prefab;



    public void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        draggingShape = true;
        Instantiate(prefab);
    }

    public void OnMouseUp()
    {
        draggingShape = false;
    }

    private void Update()
    {
        if (draggingShape)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
        }
    }

    //public void OnMouseDrag()
    //{
    //    if(Input.GetMouseButtonDown(0))
    //    {
    //        Instantiate(squarePrefab);
    //    }
    //}

    //public void InstantiateCircle()
    //{
    //    if(Input.GetMouseButtonDown(0))
    //    {
    //        Instantiate(circlePrefab);
    //    }
    //}

    //public void InstantiateTriangle()
    //{
    //    if(Input.GetMouseButtonDown(0))
    //    {
    //        Instantiate(trianglePrefab);
    //    }
    //}

    //public void InstantiateLine()
    //{
    //    if(Input.GetMouseButtonDown(0))
    //    {
    //        Instantiate(linePrefab);
    //    }
    //}


}
