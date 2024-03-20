using UnityEngine;

public class Train : MonoBehaviour
{
    [SerializeField] private TrainMovement _trainMovement;

    public void SpeedUp()
    {
        _trainMovement.SpeedUp();
    }

    public void StopSpeedingUp()
    {
        _trainMovement.StopSpeedingUp();
    }
}
