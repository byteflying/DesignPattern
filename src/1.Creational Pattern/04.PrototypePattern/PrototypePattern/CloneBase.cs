using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrototypePattern {

	[Serializable]
	public class CloneBase<T> {
		public virtual T Clone() {
			var memoryStream = new MemoryStream();
			var formatter = new BinaryFormatter();
			formatter.Serialize(memoryStream, this);
			memoryStream.Position = 0;
			return (T)formatter.Deserialize(memoryStream);
		}
	}

}