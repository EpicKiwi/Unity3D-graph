using System;

namespace AssemblyCSharp
{
	//TODO ??
	public delegate void GraphEdgeVisitor(AbstractGraphEdge edge);

	/// <summary>
	/// Abstract class representing a node in the graph
	/// </summary>
	public abstract class AbstractGraphNode : AbstractGraphElement
	{
		//TODO ??
		public abstract void Accept(GraphEdgeVisitor graphEdgeVisitor);
		//TODO ??
		public abstract long GetDegree();
		//TODO ??
		public abstract bool IsAdjacent(AbstractGraphNode graphNode);
	}
}

