using NaughtyAttributes;
using System.Collections.Generic;
using UnityEngine;



public class EnvironmentInfiniteSpawner : MonoBehaviour
{
    [SerializeField] private List<Transform> _objects;
    [SerializeField] private Transform _train;
    [SerializeField] private float _itemLength = 20.84f;
    [SerializeField] private int _preRenderItemAmount = 3;
    [SerializeField] private int _amountToRenderBehind = 2;

    public int _visibleItems;
    public int _lastVisibleItemIndex;
    public int _firstVisibleItemIndex;

    private void Awake()
    {
        _firstVisibleItemIndex = _preRenderItemAmount;
        _lastVisibleItemIndex = -_amountToRenderBehind;
        _visibleItems = _firstVisibleItemIndex - _lastVisibleItemIndex;


    }

    private void Start()
    {
        for (int i = 0; i < _objects.Count; i++)
        {
            if (i > _visibleItems)
            {
                _objects[i].gameObject.Disable();
            }
        }
    }

    private void Update()
    {

        if (_train.transform.position.x >= (_visibleItems - _preRenderItemAmount) * _itemLength)
        {
            print($"{_train.transform.position.x} {(_visibleItems - _preRenderItemAmount) * _itemLength}");
            _visibleItems++;
            _lastVisibleItemIndex++;
            if (_lastVisibleItemIndex < _objects.Count && _lastVisibleItemIndex >= 0)
            {
                _objects[_lastVisibleItemIndex].gameObject.Disable();
                print($"disable {_lastVisibleItemIndex}");
            }
            if (_firstVisibleItemIndex < _objects.Count)
            {
                _objects[_firstVisibleItemIndex].gameObject.Enable();
                print($"enable {_firstVisibleItemIndex}");
            }
            _firstVisibleItemIndex++;
        }
    }
}
