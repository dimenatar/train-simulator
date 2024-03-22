using System;

public class LevelEventsProvider
{
    private LevelEvents _levelEvents;

    public event Action Awaken;
    public event Action Started;
    public event Action LevelDestroed;
    public event Action<bool> PauseStateChanged;

    public void SetLevelEvents(LevelEvents levelEvents)
    {
        _levelEvents = levelEvents;
        Subscribe(levelEvents);
    }

    private void Subscribe(LevelEvents levelEvents)
    {
        levelEvents.Awaken += OnLevelEventsAwaken;
        levelEvents.Started += OnLevelEventsStarted;
        levelEvents.Destroed += OnLevelEventsDestroed;
        levelEvents.PauseStateChanged += OnLevelEventsPauseStateChanged;
    }

    private void Unsubscribe(LevelEvents levelEvents)
    {
        levelEvents.Awaken -= OnLevelEventsAwaken;
        levelEvents.Started -= OnLevelEventsStarted;
        levelEvents.Destroed -= OnLevelEventsDestroed;
        levelEvents.PauseStateChanged -= OnLevelEventsPauseStateChanged;
    }

    private void OnLevelEventsPauseStateChanged(bool isPause)
    {
        PauseStateChanged?.Invoke(isPause);
    }

    private void OnLevelEventsDestroed()
    {
        Unsubscribe(_levelEvents);
        LevelDestroed?.Invoke();
    }

    private void OnLevelEventsStarted()
    {
        Started?.Invoke();
    }

    private void OnLevelEventsAwaken()
    {
        Awaken?.Invoke();
    }
}
