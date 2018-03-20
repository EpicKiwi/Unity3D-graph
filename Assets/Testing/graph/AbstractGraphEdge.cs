using System;

namespace AssemblyCSharp
{
	/// <summary>
	/// Abstract graph representing an edge on the graph.
	/// </summary>
	public abstract class AbstractGraphEdge : AbstractGraphElement
	{
		/// <summary>
		/// Get the source graph node of the edge
		/// </summary>
		/// <returns>The source graph node</returns>
		public abstract AbstractGraphNode GetStartGraphNode();

		/// <summary>
		/// Get the target graph node of the edge
		/// </summary>
		/// <returns>The target graph node of the edge</returns>
		public abstract AbstractGraphNode GetEndGraphNode();
	}
}

