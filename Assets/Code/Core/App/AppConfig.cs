using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

using Core.SceneManagement;

namespace Core.CurlyApp
{
    /// <summary>
    /// Configuration Class for App. An instance must be found under Resources for App to work
    /// </summary>
    [CreateAssetMenu(menuName = "Core/App Configuration", fileName = "AppConfig")]
    public class AppConfig : ScriptableObject
    {
        [field: Header("Booter Configuration")]
        [field: SerializeField] public List<BooterObject> Booters {get; private set;} = new List<BooterObject>();

        [field: Header("Core Configuration")]
        [field: SerializeField] public SceneMaster SceneMaster {get; private set;}
        
        [Header("Gameplay")]
        // All objects that should be placed in the DontDestroyOnLoad scene on gamestart
        [SerializeField] public List<GameObject> PersistentObjects = new List<GameObject>();

        [Header("Scenes")]
        [SerializeField] public List<SceneAsset> NonGameplayScenes = new List<SceneAsset>();
    }
}
