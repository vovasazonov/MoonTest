using System;
using UnityEngine;

namespace Project.Scripts.Game.Areas.Input.Move
{
    public interface IMoveInput
    {
        event Action Updated;

        Vector2 Direction { get; }
    }
}