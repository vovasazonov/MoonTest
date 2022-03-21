using System;
using Game.Areas.Inputs;
using Project.Scripts.Game.Areas.Input.Move;

namespace Project.Scripts.Game.Base.Input
{
    public class GameInputs : IDisposable, IGameInputs
    {
        private readonly MoveInput _move;
        
        public IMoveInput Move => _move;

        public GameInputs()
        {
            GameInputControls gameInputControls = new GameInputControls();

            _move = new MoveInput(gameInputControls.Joystick.LeftStick);
            
            gameInputControls.Enable();
        }

        public void Dispose()
        {
            _move.Dispose();
        }
    }
}