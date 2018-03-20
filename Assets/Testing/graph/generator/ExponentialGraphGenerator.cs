using System;

namespace AssemblyCSharp
{
	/// <summary>
	/// Generates an exponential graph
	/// </summary>
	public class ExponentialGraphGenerator : AbstractGraphGenerator
	{
		/// <summary>
		/// The max level of the graph
		/// </summary>
		private const int MAX_LEVEL = 3;

		/// <summary>
		/// Generates a graph with exponential number of Nodes 
		/// </summary>
		/// <param name="graph">The graph object where the graph will be generated</param>
		public override void GenerateGraph (Graph graph)
		{
			AbstractGraphNode root = graph.NewNode ();
			GenerateDescedants (1, graph, root);
		}

		/// <summary>
		/// Recursive method that generates the descedants of a defined node
		/// </summary>
		/// <param name="level">Current level of the node</param>
		/// <param name="graph">The graph to add the node to</param>
		/// <param name="startNode">The original node to add the childrens to</param>
		void GenerateDescedants (int level, Graph graph, AbstractGraphNode startNode)
		{
			if (level > MAX_LEVEL) {
				return;
			}
			for (int index = 0; index < Math.Exp(level); index++) {
				AbstractGraphNode descedantNode = graph.NewNode ();
				graph.NewEdge (startNode, descedantNode);

				GenerateDescedants (level + 1, graph, descedantNode);
			}
		}
	}
}

