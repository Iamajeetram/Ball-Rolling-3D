using UnityEngine;
using UnityEngine.EventSystems;

public class PressHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Movement movement;
    public bool isLeftButton;
    bool isPressed;
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isLeftButton && isPressed)
        {
            movement.MoveLeft();
        }
        else if (!isLeftButton && isPressed)
        {
            movement.MoveRight();
        }
    }
}
