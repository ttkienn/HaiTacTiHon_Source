namespace System;

internal class TermInfoReader
{
	private int boolSize; //Field offset: 0x10
	private int numSize; //Field offset: 0x14
	private int strOffsets; //Field offset: 0x18
	private Byte[] buffer; //Field offset: 0x20
	private int booleansOffset; //Field offset: 0x28
	private int intOffset; //Field offset: 0x2C

	public TermInfoReader(string term, string filename) { }

	public TermInfoReader(string term, Byte[] buffer) { }

	private void DetermineVersion(short magic) { }

	public int Get(TermInfoNumbers number) { }

	public string Get(TermInfoStrings tstr) { }

	private short GetInt16(Byte[] buffer, int offset) { }

	private string GetString(Byte[] buffer, int offset) { }

	public Byte[] GetStringBytes(TermInfoStrings tstr) { }

	private Byte[] GetStringBytes(Byte[] buffer, int offset) { }

	private void ReadHeader(Byte[] buffer, ref int position) { }

	private void ReadNames(Byte[] buffer, ref int position) { }

}

