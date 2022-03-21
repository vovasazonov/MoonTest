using Project.Scripts.Game.Base.Config;
using Project.Scripts.Game.Base.View;
using UnityEngine;

public class Entry : MonoBehaviour
{
    [SerializeField] private GameConfig _config;
    [SerializeField] private GameView _view;
    
    private Project.Scripts.Game.Game _game;
    
    private void Start()
    {
        _game = new Project.Scripts.Game.Game(_config, _view);
    }

    private void OnDestroy()
    {
        _game?.Dispose();
    }
}