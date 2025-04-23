using UnityEngine;
using UnityEngine.UI;

public class WireDrawer : MonoBehaviour
{
    public static WireDrawer Instance;

    public GameObject wirePrefab;
    private RectTransform currentWire;
    private RectTransform startNode;
    private Canvas canvas;

    void Awake()
    {
        Instance = this;
        canvas = FindObjectOfType<Canvas>();
    }

    public void BeginWire(RectTransform start)
    {
        startNode = start;

        if (currentWire != null)
            Destroy(currentWire.gameObject);

        GameObject wireObj = Instantiate(wirePrefab, canvas.transform);
        currentWire = wireObj.GetComponent<RectTransform>();
        currentWire.gameObject.SetActive(true);
    }

    void Update()
    {
        if (currentWire == null || startNode == null) return;

        Vector2 startPos = startNode.anchoredPosition;
        Vector2 endPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, Input.mousePosition, canvas.worldCamera, out endPos);

        Vector2 direction = endPos - startPos;
        float length = direction.magnitude;

        currentWire.anchoredPosition = startPos;
        currentWire.sizeDelta = new Vector2(length, 4f); // width fixed at 4
        currentWire.rotation = Quaternion.FromToRotation(Vector3.right, direction);
    }

    public void EndWire()
    {
        // Add logic to check if it's connected to a valid target
        Destroy(currentWire.gameObject);
        currentWire = null;
        startNode = null;
    }
}
