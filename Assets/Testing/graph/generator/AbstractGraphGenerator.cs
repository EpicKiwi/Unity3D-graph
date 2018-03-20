using System;

namespace AssemblyCSharp
{
	/// <summary>
	/// Abstract class for graph generators.
	/// A generators creates a graph from parameters
	/// </summary>
	public abstract class AbstractGraphGenerator
	{

		/// <summary>
		/// Generates the graph.
		/// </summary>
		/// <param name="graph">The graph object where the graph will be generated</param>
		public abstract void GenerateGraph(Graph graph);
	}
}

