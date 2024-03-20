using UnityEngine;

public abstract class TrainMovement : MonoBehaviour
{
    public abstract void SpeedUp();
    public abstract void StopSpeedingUp();
    public abstract float GetSpeed();
}
