using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableWire : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private Vector2 originalPos;
    public RectTransform correctTarget;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        originalPos = rectTransform.anchoredPosition;
        canvas = GetComponentInParent<Canvas>();
    }

    public void OnBeginDrag(PointerEventData eventData) { }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (RectTransformUtility.RectangleContainsScreenPoint(correctTarget, Input.mousePosition, canvas.worldCamera))
        {
            Debug.Log("Connected!");
            rectTransform.anchoredPosition = correctTarget.anchoredPosition;
        }
        else
        {
            Debug.Log("Wrong spot");
            rectTransform.anchoredPosition = originalPos;
        }
    }
}
