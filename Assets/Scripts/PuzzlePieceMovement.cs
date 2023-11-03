using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PuzzlePieceMovement : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    //Variables
    private RectTransform rectTransform;
    private Image image;

    public void OnBeginDrag(PointerEventData eventData)
    {
        image.color = new Color(255, 255, 255, 100);
    }

    public void OnDrag(PointerEventData eventData)
    {
        //rectTransform.anchoredPosition += eventData.delta;
        rectTransform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        image.color = new Color(255, 255, 255, 255);
    }

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
    }
}
