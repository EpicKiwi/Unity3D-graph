using System;
using UnityEngine;

namespace AssemblyCSharp
{
	/// <summary>
	/// Data class storing the Prefabs used by the GraphScene class to render the Unity Scene
	/// </summary>
	public class GraphScenePrefabs : MonoBehaviour
	{
		
		/// <summary>
		/// Prefab used to represent nodes
		/// </summary>
		public GameObject NodePrefab;
		/// <summary>
		/// Prefab used to represent Edge
		/// </summary>
		public GameObject EdgePrefab;

		/// <summary>
		/// Procedure to instanciate a node in the scene
		/// </summary>
		/// <returns>The node gameObject</returns>
		public GameObject InstantiateNode()
		{
			GameObject node = Instantiate (NodePrefab);
			node.transform.SetParent (transform);
			return node;
		}

		/// <summary>
		/// Procedure to instanciate an edge in the scene
		/// </summary>
		/// <returns>The edge gameObject</returns>
		public GameObject InstantiateEdge()
		{
			GameObject edge = Instantiate (EdgePrefab);
			edge.transform.SetParent (transform);
			return edge;
		}
	}
}

