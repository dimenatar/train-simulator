using AYellowpaper.SerializedCollections;
using SceneLoading;
using System.Collections.Generic;
using UnityEngine;

namespace Scriptables
{
    [CreateAssetMenu(order = 40)]
    public class SceneNamesBundle : ScriptableObject
    {
        [SerializeField] private SerializedDictionary<SceneType, string> _sceneNames;

        public Dictionary<SceneType, string> SceneNames => new Dictionary<SceneType, string>(_sceneNames);
    }
}