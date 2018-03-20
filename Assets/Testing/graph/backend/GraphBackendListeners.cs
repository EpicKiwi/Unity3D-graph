using System;
using System.Collections.Generic;
using AssemblyCSharp;

namespace AssemblyCSharp
{
	/// <summary>
	/// The Event Emitter of graph events. Store all the subscribed listeners and notify them.
	/// </summary>
	public class GraphBackendListeners
	{

		/// <summary>
		/// Listeners subscribed to this Emitter.
		/// </summary>
		private List<GraphBackendListener> listeners = new List<GraphBackendListener>(); 

		/// <summary>
		/// Register a listener. This listener will be notified when an event is called.
		/// </summary>
		/// <param name="listener">Listener to register</param>
		public void AddGraphBackendListener(GraphBackendListener listener) 
		{
			listeners.Add (listener);
		}

		/// <summary>
		/// Notify all the listeners that a new node is created
		/// </summary>
		/// <param name="graphNode">New graph node.</param>
		public void NotifyGraphBackendCreated(AbstractGraphNode graphNode)
		{
			listeners.ForEach (listener => {
				listener.GraphBackendNodeCreated(graphNode);
			});
		}

		/// <summary>
		/// Notify all the listeners that a new edge is created
		/// </summary>
		/// <param name="graphEdge">New graph edge.</param>
		public void NotifyGraphBackendCreated(AbstractGraphEdge graphEdge)
		{
			listeners.ForEach (listener => {
				listener.GraphBackendEdgeCreated(graphEdge);
			});
		}
	}
}

