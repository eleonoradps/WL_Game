using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeContainerActivator : MonoBehaviour
{
    [SerializeField] private GameObject shapeContainerP1;
    [SerializeField] private GameObject shapecontainerP2;

    private bool isShapeContainerP1Active = false;
    private bool isShapeContainerP2Active = false;

    public void ActivateP1ShapeContainer()
    {
        isShapeContainerP1Active = !isShapeContainerP1Active;
        shapeContainerP1.SetActive(isShapeContainerP1Active);
    }

    public void ActivateP2ShapeContainer()
    {
        isShapeContainerP2Active = !isShapeContainerP2Active;
        shapecontainerP2.SetActive(true);
    }
}
