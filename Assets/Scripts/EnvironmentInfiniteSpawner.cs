using NaughtyAttributes;
using UnityEngine;



public class EnvironmentInfiniteSpawner : MonoBehaviour
{
    [SerializeField] private Transform _parent;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private float _offset;
    [SerializeField] private int _spawningAmount;

    private void Awake()
    {
        
    }

    private void Update()
    {
        
    }

    [Button]
    public void Spawn()
    {
        for (int i = 0; i < _spawningAmount; i++)
        {
            var copy = Instantiate(_prefab, _parent);
            copy.transform.position = new Vector3(i * _offset, 0f, 0f);
        }
    }
}
