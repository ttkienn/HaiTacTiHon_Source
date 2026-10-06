namespace System.Globalization;

internal static class EncodingTable
{
	internal static InternalEncodingDataItem[] encodingDataPtr; //Field offset: 0x0
	internal static InternalCodePageDataItem[] codePageDataPtr; //Field offset: 0x8
	private static int lastEncodingItem; //Field offset: 0x10
	private static Dictionary<String, Int32> hashByName; //Field offset: 0x18
	private static Dictionary<Int32, CodePageDataItem> hashByCodePage; //Field offset: 0x20

	private static EncodingTable() { }

	private static InternalEncodingDataItem ENC(string name, ushort cp) { }

	internal static CodePageDataItem GetCodePageDataItem(int codepage) { }

	internal static int GetCodePageFromName(string name) { }

	private static int GetNumEncodingItems() { }

	private static int internalGetCodePageFromName(string name) { }

	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags) { }

}

