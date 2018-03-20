using System;

namespace AssemblyCSharp
{
	/// <summary>
	/// Generator of a circular graph
	/// </summary>
	public class CircularGraphGenerator : AbstractGraphGenerator
	{
		/// <summary>
		/// Number of nodes in the circle.
		/// </summary>
		private const int NODES = 100;

		/// <summary>
		/// Generates a circular graph.
		/// </summary>
		/// <param name="graph">The graph object where the graph will be generated.</param>
		public override void GenerateGraph (Graph graph)
		{
			AbstractGraphNode root = graph.NewNode ();
			AbstractGraphNode lastNode = GenerateCircleSegment (graph, root, 0);

			graph.NewEdge (lastNode, root);
		}

		/// <summary>
		/// Recursive method that creates a segment of the circle graph
		/// </summary>
		/// <returns>The circle segment.</returns>
		/// <param name="graph">The graph where the node will be added.</param>
		/// <param name="startNode">The last node to connect to.</param>
		/// <param name="segmentIndex">The index of the node to generate.</param>
		private AbstractGraphNode GenerateCircleSegment(Graph graph, AbstractGraphNode startNode, int segmentIndex)
		{
			if (segmentIndex > NODES) {
				return startNode;
			}
			AbstractGraphNode neighborNode = graph.NewNode ();
			graph.NewEdge (startNode, neighborNode);
			return GenerateCircleSegment (graph, neighborNode, segmentIndex + 1);
		}
	}
}

