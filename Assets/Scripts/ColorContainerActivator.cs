using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorContainerActivator : MonoBehaviour
{
    [SerializeField] private GameObject colorContainerP1;
    [SerializeField] private GameObject colorcontainerP2;

    private bool isColorContainerP1Active = false;
    private bool isColorContainerP2Active = false;

    public void ActivateP1ColorContainer()
    {
        isColorContainerP1Active = !isColorContainerP1Active;
        colorContainerP1.SetActive(isColorContainerP1Active);
    }

    public void ActivateP2ColorContainer()
    {
        isColorContainerP2Active = !isColorContainerP2Active;
        colorcontainerP2.SetActive(true);
    }
}
