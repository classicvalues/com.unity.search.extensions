#if USE_SEARCH_TABLE
using System.Collections.Generic;

namespace UnityEditor.Search
{
    interface IGraphLayout
    {
        bool Animated { get; }
        bool Calculate(Graph graph, float deltaTime);
    }
}
#endif
