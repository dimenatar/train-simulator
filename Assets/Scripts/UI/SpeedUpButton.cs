using UnityEngine;
using UnityEngine.EventSystems;

public class SpeedUpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Train _train;

    public void OnPointerDown(PointerEventData eventData)
    {
        print("d");
        _train.SpeedUp();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        print("u");
        _train.StopSpeedingUp();
    }
}
