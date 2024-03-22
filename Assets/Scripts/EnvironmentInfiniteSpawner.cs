using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Environment
{
    [SerializeField] private Transform _transform;
    [SerializeField] private float _length;
    [SerializeField] private int _startAmountOnLevel;

    public int timesSpawned;

    public Transform Transform { get => _transform; private set => _transform = value; }
    public float Length { get => _length; private set => _length = value; }
    public int StartAmountOnLevel {get => _startAmountOnLevel; private set => _startAmountOnLevel = value; }
}

public class EnvironmentInfiniteSpawner : MonoBehaviour
{
    [SerializeField] private Transform _train;
    [SerializeField] private List<Environment> _environmentList;

    private float _passedDistance;

    private void Awake()
    {
        
    }

    private void Update()
    {
        
    }
}
