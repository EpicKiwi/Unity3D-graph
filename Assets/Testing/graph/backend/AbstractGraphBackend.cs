using System;

namespace AssemblyCSharp
{
	/// <summary>
	/// Abstract class for graph backends. Graph backends are storing objects containing all the graph nodes and edges
	/// </summary>
	public abstract class AbstractGraphBackend
	{
		/// <summary>
		/// Event emitter of this backend. Notify listeners when a component of the graph is modified
		/// </summary>
		private GraphBackendListeners listeners = new GraphBackendListeners();
	
		/// <summary>
		/// Creates a new Node
		/// </summary>
		/// <returns>The new Node</returns>
		public abstract AbstractGraphNode NewNode();

		/// <summary>
		/// Creates a new edge
		/// </summary>
		/// <returns>The new Edge</returns>
		/// <param name="from">Source Node</param>
		/// <param name="to">Target Node</param>
		public abstract AbstractGraphEdge NewEdge(AbstractGraphNode from, AbstractGraphNode to);

		/// <summary>
		/// Gets a node by it's identifier.
		/// </summary>
		/// <returns>The Node associated to the identifier</returns>
		/// <param name="nodeId">Node identifier</param>
		public abstract AbstractGraphNode GetNodeById(long nodeId);

		/// <summary>
		/// Return the total number of edges in the backend
		/// </summary>
		/// <returns>Number of edges in the backend</returns>
		public abstract long CountAllEdges();

		/// <summary>
		/// Return the total number of Nodes in the backend
		/// </summary>
		/// <returns>Number of edges in the backend</returns>
		public abstract long CountAllNodes();

		/// <summary>
		/// Register a listener to this backend
		/// </summary>
		/// <param name="listener">Listener to register</param>
		public void AddListener(GraphBackendListener listener)
		{
			listeners.AddGraphBackendListener (listener);
		}

		/// <summary>
		/// Notify the listeners that a node is created
		/// </summary>
		/// <param name="graphNode">Created node</param>
		public void NotifyBackendNodeCreated(AbstractGraphNode graphNode)
		{
			listeners.NotifyGraphBackendCreated (graphNode);
		}

		/// <summary>
		/// Notify the listeners that an edge is created
		/// </summary>
		/// <param name="graphEdge">Created edge</param>
		public void NotifyBackendEdgeCreated(AbstractGraphEdge graphEdge)
		{
			listeners.NotifyGraphBackendCreated (graphEdge);
		}
	}
}

