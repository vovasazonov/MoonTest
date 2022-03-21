using System.Collections.Generic;
using Project.Scripts.Core.View;

namespace Project.Scripts.Core.Presenter
{
    public class PrimitivesPresenter : IPresenter
    {
        private readonly List<IPrimitiveView> _views = new();
        
        public PrimitivesPresenter(IEnumerable<IViewCreator<IPrimitiveView>> views)
        {
            foreach (var view in views)
            {
                _views.Add(view.Create());
            }
        }

        public void Dispose()
        {
            _views.ForEach(i=>i.Dispose());
            _views.Clear();
        }
    }
}