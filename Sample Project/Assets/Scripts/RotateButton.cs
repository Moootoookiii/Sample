using UnityEngine;
using UnityEngine.EventSystems;

public class RotateButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{

    public static bool onButtonDown;//ボタンがクリックされてるかを判定！

    /// <summary>
    /// ボタンが押されたと検出
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        onButtonDown = true;
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        onButtonDown = false;
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        onButtonDown = true;
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        onButtonDown = false;
    }

    private void Update()
    {
        Debug.Log(onButtonDown);
    }

    private void Rotate()
    {
    //    Debug.Log("Rotate");
    }
}
