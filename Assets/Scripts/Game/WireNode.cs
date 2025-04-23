using UnityEngine;
using UnityEngine.EventSystems;

public class WireNode : MonoBehaviour, IPointerClickHandler
{
    public bool isStartNode = true;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isStartNode)
        {
            WireDrawer.Instance.BeginWire(transform as RectTransform);
        }
    }
}
