namespace System;

internal class TypeIdentifiers
{
	private class Display : ATypeName, TypeIdentifier, TypeName, IEquatable<TypeName>
	{
		private string displayName; //Field offset: 0x10
		private string internal_name; //Field offset: 0x18

		public virtual string DisplayName
		{
			 get { } //Length: 5
		}

		public override string InternalName
		{
			 get { } //Length: 253
		}

		internal Display(string displayName) { }

		public virtual string get_DisplayName() { }

		public override string get_InternalName() { }

		private string GetInternalName() { }

	}


	internal static TypeIdentifier FromDisplay(string displayName) { }

}

