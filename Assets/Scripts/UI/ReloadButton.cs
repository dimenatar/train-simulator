using SceneLoading;
using UnityEngine;
using Zenject;

public class ReloadButton : MonoBehaviour
{
    private LevelLoader _levelLoader;

    [Inject]
    private void Construct(LevelLoader levelLoader)
    {
        _levelLoader = levelLoader;
    }

    public void Reload()
    {
        _levelLoader.ReloadScene();
    }
}
