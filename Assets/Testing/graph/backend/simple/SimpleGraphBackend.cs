using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	/// <summary>
	/// Simple graph backend that store all nodes and all edges in two lists.
	/// Nodes created ar SimpleGraphNode and edges SimpleGraphEdge
	/// </summary>
	public class SimpleGraphBackend : AbstractGraphBackend
	{
		/// <summary>
		/// Nodes of the graph
		/// </summary>
		private List<AbstractGraphNode> AllGraphNodes = new List<AbstractGraphNode>();
		/// <summary>
		/// Edges of the graph
		/// </summary>
		private List<AbstractGraphEdge> AllGraphEdges = new List<AbstractGraphEdge>();

		/// <summary>
		/// Creates a new SimpleGraphNode
		/// </summary>
		/// <returns>The new SimpleGraphNode</returns>
		public override AbstractGraphNode NewNode ()
		{
			SimpleGraphNode newNode = new SimpleGraphNode (this, AllGraphNodes.Count);
			AllGraphNodes.Add (newNode);
			NotifyBackendNodeCreated (newNode);
			return newNode;
		}

		/// <summary>
		/// Creates a new SimpleGraphEdge
		/// </summary>
		/// <returns>The new SimpleGraphEdge</returns>
		/// <param name="from">Source Node</param>
		/// <param name="to">Target Node</param>
		public override AbstractGraphEdge NewEdge (AbstractGraphNode from, AbstractGraphNode to)
		{
			SimpleGraphEdge newEdge = new SimpleGraphEdge (AllGraphEdges.Count, from, to);
			AllGraphEdges.Add (newEdge);
			NotifyBackendEdgeCreated (newEdge);
			return newEdge;
		}

		/// <summary>
		/// Gets a node by it's identifier.
		/// </summary>
		/// <returns>The Node associated to the identifier</returns>
		/// <param name="nodeId">Node identifier</param>
		public override AbstractGraphNode GetNodeById (long nodeId)
		{
			return AllGraphNodes.Find (node => {
				return node.GetId() == nodeId;
			});
		}

		/// <summary>
		/// Finds edges of a node.
		/// </summary>
		/// <returns>Edges connected to node.</returns>
		/// <param name="nodeId">Node identifier.</param>
		public List<AbstractGraphEdge> FindEdges(long nodeId) {
			return AllGraphEdges.FindAll (edge => {
				AbstractGraphNode startNode = edge.GetStartGraphNode();
				AbstractGraphNode endNode = edge.GetEndGraphNode();
				return startNode.GetId() == nodeId || endNode.GetId() == nodeId;
			});
		}

		/// <summary>
		/// Find edges between two nodes
		/// </summary>
		/// <returns>Connected edges between two nodes</returns>
		/// <param name="startOrEndNodeId">First node identifier.</param>
		/// <param name="endOrStartNodeId">other node identifier.</param>
		public List<AbstractGraphEdge> FindEdges(long startOrEndNodeId, long endOrStartNodeId) {
			return AllGraphEdges.FindAll (edge => {
				AbstractGraphNode startNode = edge.GetStartGraphNode();
				AbstractGraphNode endNode = edge.GetEndGraphNode();
			
				return (startNode.GetId() == startOrEndNodeId && endNode.GetId() == endOrStartNodeId) 
					|| (startNode.GetId() == endOrStartNodeId && endNode.GetId() == startOrEndNodeId);
			});
		}

		/// <summary>
		/// Return the total number of edges in the backend
		/// </summary>
		/// <returns>Number of edges in the backend</returns>
		public override long CountAllEdges ()
		{
			return AllGraphEdges.Count;
		}

		/// <summary>
		/// Return the total number of Nodes in the backend
		/// </summary>
		/// <returns>Number of edges in the backend</returns>
		public override long CountAllNodes ()
		{
			return AllGraphNodes.Count;
		}
	}
}

