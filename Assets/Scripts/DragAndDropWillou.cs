using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDropWillou : MonoBehaviour, IDragHandler 
{
    
    public void OnDrag(PointerEventData eventData)
    {
        GetComponent<Image>().color = FindObjectOfType<ColorsManager>().GetComponent<ColorsManager>().CurrentColor;
        transform.position = Input.mousePosition;
    }
}
