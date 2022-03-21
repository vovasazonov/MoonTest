using System.Collections.Generic;
using Project.Scripts.Core.Presenter;
using Project.Scripts.Game.Base.Config;
using Project.Scripts.Game.Base.Model;
using Project.Scripts.Game.Base.View;

namespace Project.Scripts.Game.Base.Presenter
{
    public class GamePresenter : Core.Presenter.IPresenter
    {
        private readonly List<IPresenter> _presenters = new();
        
        public GamePresenter(IGameModel model, IGameView view, IGameConfig config)
        {
            _presenters.Add(new PrimitivesPresenter(view.Primitives));
        }

        public void Dispose()
        {
            _presenters.ForEach(i=>i.Dispose());
            _presenters.Clear();
        }
    }
}