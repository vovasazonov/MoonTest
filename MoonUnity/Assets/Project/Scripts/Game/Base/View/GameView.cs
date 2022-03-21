using System.Collections.Generic;
using System.Linq;
using Project.Scripts.Core.View;
using UnityEngine;

namespace Project.Scripts.Game.Base.View
{
    public class GameView : MonoBehaviour, IGameView
    {
        [SerializeField] private List<PrimitiveView> _primitives;
        
        public IEnumerable<IViewCreator<IPrimitiveView>> Primitives { get; private set; }

        private void Awake()
        {
            var primitiveParent = new GameObject("Primitives").transform;
            Primitives = _primitives.Select(i => new ViewCreator<PrimitiveView>(i, primitiveParent));
        }
    }
}