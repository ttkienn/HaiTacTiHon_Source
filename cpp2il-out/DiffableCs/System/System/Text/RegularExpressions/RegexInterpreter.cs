namespace System.Text.RegularExpressions;

internal sealed class RegexInterpreter : RegexRunner
{
	private readonly RegexCode _code; //Field offset: 0x80
	private readonly CultureInfo _culture; //Field offset: 0x88
	private int _operator; //Field offset: 0x90
	private int _codepos; //Field offset: 0x94
	private bool _rightToLeft; //Field offset: 0x98
	private bool _caseInsensitive; //Field offset: 0x99

	public RegexInterpreter(RegexCode code, CultureInfo culture) { }

	private void Advance(int i) { }

	private void Backtrack() { }

	private void Backwardnext() { }

	private int Bump() { }

	private char CharAt(int j) { }

	protected virtual bool FindFirstChar() { }

	private char Forwardcharnext() { }

	private int Forwardchars() { }

	protected virtual void Go() { }

	private void Goto(int newpos) { }

	protected virtual void InitTrackCount() { }

	private int Leftchars() { }

	private int Operand(int i) { }

	private int Operator() { }

	private bool Refmatch(int index, int len) { }

	private int Rightchars() { }

	private void SetOperator(int op) { }

	private int StackPeek(int i) { }

	private int StackPeek() { }

	private void StackPop() { }

	private void StackPop(int framesize) { }

	private void StackPush(int I1) { }

	private void StackPush(int I1, int I2) { }

	private bool Stringmatch(string str) { }

	private int Textpos() { }

	private int Textstart() { }

	private void Textto(int newpos) { }

	private int TrackPeek() { }

	private int TrackPeek(int i) { }

	private void TrackPop(int framesize) { }

	private void TrackPop() { }

	private int Trackpos() { }

	private void TrackPush(int I1, int I2, int I3) { }

	private void TrackPush(int I1, int I2) { }

	private void TrackPush() { }

	private void TrackPush(int I1) { }

	private void TrackPush2(int I1, int I2) { }

	private void TrackPush2(int I1) { }

	private void Trackto(int newpos) { }

}

