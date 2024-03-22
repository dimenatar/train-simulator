using UnityEngine;
using UnityEngine.EventSystems;

public class SpeedUpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Train _train;

    public void OnPointerDown(PointerEventData eventData)
    {
        _train.SpeedUp();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _train.StopSpeedingUp();
    }
}
