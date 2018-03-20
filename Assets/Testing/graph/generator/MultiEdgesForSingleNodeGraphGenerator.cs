using System;

namespace AssemblyCSharp
{
	/// <summary>
	/// Basic generator for Test purpose
	/// </summary>
	public class MultiEdgesForSingleNodeGraphGenerator : AbstractGraphGenerator
	{
		/// <summary>
		/// Generates a graph with 8 Edges and 3 nodes
		/// </summary>
		/// <param name="graph">The graph object where the graph will be generated</param>
		public override void GenerateGraph (Graph graph)
		{
			AbstractGraphNode firstNode =  graph.NewNode();
			AbstractGraphNode secondNode = graph.NewNode ();
			AbstractGraphNode thirdNode = graph.NewNode ();

			graph.NewEdge (firstNode, secondNode);
			graph.NewEdge (secondNode, firstNode);
			graph.NewEdge (firstNode, secondNode);
			graph.NewEdge (firstNode, secondNode);
			graph.NewEdge (firstNode, secondNode);
			graph.NewEdge (firstNode, secondNode);
			graph.NewEdge (firstNode, secondNode);

			graph.NewEdge (secondNode, thirdNode);
		}
	}
}

