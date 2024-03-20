using Cysharp.Threading.Tasks;
using Scriptables;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace SceneLoading
{
    public class LevelLoader
    {
        private Dictionary<SceneType, string> _sceneNames;

        public LevelLoader(SceneNamesBundle sceneNamesBundle)
        {
            _sceneNames = sceneNamesBundle.SceneNames;
        }

        public void LoadScene(SceneType sceneType)
        {
            SceneManager.LoadScene(_sceneNames[sceneType]);
        }

        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        public async void LoadSceneAsync(SceneType sceneType)
        {
            var operation = SceneManager.LoadSceneAsync(_sceneNames[sceneType]);
            await operation;
        }

        public async void LoadSceneAsync(string sceneName)
        {
            var operation = SceneManager.LoadSceneAsync(sceneName);
            await operation;
        }

        public void ReloadScene()
        {
            var currentSceneName = SceneManager.GetActiveScene().name;
            LoadScene(currentSceneName);
        }

        public async void ReloadSceneAsync()
        {
            var currentSceneName = SceneManager.GetActiveScene().name;
            await SceneManager.LoadSceneAsync(currentSceneName);
        }
    }
}