using SceneLoading;
using Scriptables;
using UnityEngine;
using Zenject;

namespace Installers
{
    public class ProjectInstaller : MonoInstaller
    {
        [SerializeField] private SceneNamesBundle _sceneNamesBundle;

        public override void InstallBindings()
        {
            LevelLoader levelLoader = new LevelLoader(_sceneNamesBundle);
            LevelEventsProvider levelEventsProvider = new LevelEventsProvider();

            Container.Bind<LevelLoader>().FromInstance(levelLoader).AsSingle();
            Container.Bind<LevelEventsProvider>().FromInstance(levelEventsProvider).AsSingle();
        }
    }
}