namespace System;

internal class TypeNames
{
	public abstract class ATypeName : TypeName, IEquatable<TypeName>
	{

		public abstract string DisplayName
		{
			 get { } //Length: 0
		}

		protected ATypeName() { }

		public override bool Equals(TypeName other) { }

		public virtual bool Equals(object other) { }

		public abstract string get_DisplayName() { }

		public virtual int GetHashCode() { }

	}


}

