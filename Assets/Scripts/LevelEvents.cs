using System;
using UnityEngine;

public class LevelEvents : MonoBehaviour
{
    public event Action Awaken;
    public event Action Started;
    public event Action Destroed;
    public event Action<bool> PauseStateChanged;

    private void Awake()
    {
        Awaken?.Invoke();
    }

    private void Start()
    {
        Started?.Invoke();
    }

    private void OnDestroy()
    {
        Destroed?.Invoke();
    }

    private void OnApplicationPause(bool pause)
    {
        PauseStateChanged?.Invoke(pause);
    }
}
