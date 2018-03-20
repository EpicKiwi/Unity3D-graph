using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssemblyCSharp;

/// <summary>
/// Script to create and Render a Force-directed Graph in Unity scene
/// </summary>
public class GraphRenderer : MonoBehaviour {

	/// <summary>
	/// The prefabs used to represent Nodes and Edges
	/// </summary>
	public GraphScenePrefabs graphScenePrefabs;
	/// <summary>
	/// The camera
	/// </summary>
	public Camera cam;

	/// <summary>
	/// The instance of Graph class representing the graph in memory
	/// </summary>
	private Graph graph;
	/// <summary>
	/// The graph scene that render and positionnates the graph components in the Unity scene
	/// </summary>
	private GraphScene graphScene;

	void Start()
	{
		// Create a new Graph with simple backend to store graph components
		graph = new Graph (InitializeGraphBackend ());
		// Create a new Graph scene with created graph and specified prefabs
		graphScene = new GraphScene (graph, graphScenePrefabs);
		// Generation of testing graph
		GenerateTestData ();
		// Render the graph in the Unity Scene
		graphScene.DrawGraph ();
	}

	/// <summary>
	/// Initialize a graph backend with no node and edges in it
	/// </summary>
	/// <returns>The graph backend.</returns>
	private AbstractGraphBackend InitializeGraphBackend()
	{
		return new SimpleGraphBackend ();
	}

	/// <summary>
	/// Generates test data on the class graph.
	/// * ExponentialGraphGenerator creates a graph with exponential number of nodes recursively on depth defined in MAX_LEVEL constant
	/// * CircularGraphGenerator creates a ring graph with number of nodes defined in NODES constant
	/// * MultiEdgesForSingNodeGraphGenerator creates a graph with multi edges on a single node
	/// </summary>
	private void GenerateTestData()
	{
		new ExponentialGraphGenerator ().GenerateGraph (graph);
	}

	/// <summary>
	/// Update the game scene of one step to organize the graph
	/// </summary>
	void Update ()
	{
		graphScene.Update (1);
	}
}
