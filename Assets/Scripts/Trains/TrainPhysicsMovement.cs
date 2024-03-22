using UnityEngine;

public class TrainPhysicsMovement : TrainMovement
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Transform _forcePoint;
    [SerializeField] private float _hp;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private AnimationCurve _powerCurve;

    private bool _isSpeedingUp;

    private void Update()
    {
        if (_isSpeedingUp)
        {
            CalculateForce();
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

    private void CalculateForce()
    {
        var speed = GetSpeed();
        var procentage = speed / _maxSpeed;
        var animatedPower = _powerCurve.Evaluate(procentage) * _hp;
        _rigidbody.AddForceAtPosition(_forcePoint.right * animatedPower, _forcePoint.position, ForceMode2D.Force);
    }
}
