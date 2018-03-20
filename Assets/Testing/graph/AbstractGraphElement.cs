using System;

namespace AssemblyCSharp
{
	/// <summary>
	/// Abstract class for all Graph component
	/// </summary>
	public abstract class AbstractGraphElement
	{
		/// <summary>
		/// Gets the identifier of this element
		/// </summary>
		/// <returns>The identifier of the elemnt</returns>
		public abstract long GetId();
	}
}

