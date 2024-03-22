using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ParallaxItem
{
    [SerializeField] private Transform _transform;
    [SerializeField] private float _effect;

    public float _startPositionX;

    public Transform Transform { get => _transform;}
    public float Effect { get => _effect; }
}

public class Parallax : MonoBehaviour
{
    [SerializeField] private List<ParallaxItem> _items;
    [SerializeField] private float _smoothness;

    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Start()
    {
        _items.ForEach(item =>
        {
            item._startPositionX = item.Transform.position.x;
        });
    }

    private void FixedUpdate()
    {
        float distanceX;
        Vector3 currentPosition;
        _items.ForEach(item =>
        {
            distanceX = (_camera.transform.position.x * (1 - item.Effect));
            currentPosition = item.Transform.position;
            item.Transform.position = Vector3.Lerp(currentPosition, new Vector3(item._startPositionX + distanceX, currentPosition.y, currentPosition.z), Time.fixedDeltaTime * _smoothness);
        });
    }
}
