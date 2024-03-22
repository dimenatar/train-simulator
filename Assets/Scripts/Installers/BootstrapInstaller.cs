using SceneLoading;
using Zenject;

public class BootstrapInstaller : MonoInstaller
{
    private LevelLoader _levelLoader;

    [Inject]
    private void Construct(LevelLoader levelLoader)
    {
        _levelLoader = levelLoader;
    }

    public override void InstallBindings()
    {
        _levelLoader.LoadScene(SceneType.Gameplay);
    }
}
