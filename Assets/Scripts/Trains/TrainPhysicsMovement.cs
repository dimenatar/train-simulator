using UnityEngine;

public class TrainPhysicsMovement : TrainMovement
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Transform _forcePoint;
    [SerializeField] private float _hp;

    private bool _isSpeedingUp;

    private void Update()
    {
        if (_isSpeedingUp)
        {
            _rigidbody.AddForceAtPosition(_forcePoint.forward * _hp, _forcePoint.position, ForceMode2D.Force);
        }
    }

    public override float GetSpeed()
    {
        return _rigidbody.velocity.magnitude;
    }

    public override void SpeedUp()
    {
        _isSpeedingUp = true;
    }

    public override void StopSpeedingUp()
    {
        _isSpeedingUp = false;
    }
}
