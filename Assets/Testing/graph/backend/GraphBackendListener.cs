using System;

namespace AssemblyCSharp
{
	/// <summary>
	/// Class to handle events when a node or and edge is created
	/// </summary>
	public interface GraphBackendListener
	{
		/// <summary>
		/// Mathod called when a node is created
		/// </summary>
		/// <param name="graphNode">The new node</param>
		void GraphBackendNodeCreated(AbstractGraphNode graphNode);

		/// <summary>
		/// Mehtod called when an edge is created
		/// </summary>
		/// <param name="graphEdge">The new edge</param>
		void GraphBackendEdgeCreated(AbstractGraphEdge graphEdge);
	}
}

