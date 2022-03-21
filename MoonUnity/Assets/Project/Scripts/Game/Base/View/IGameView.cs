using System.Collections.Generic;
using Project.Scripts.Core.View;

namespace Project.Scripts.Game.Base.View
{
    public interface IGameView
    {
        IEnumerable<IViewCreator<IPrimitiveView>> Primitives { get; }
    }
}