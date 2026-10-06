namespace System.Text.RegularExpressions;

public class Regex : ISerializable
{
	public sealed class CachedCodeEntry
	{
		public CachedCodeEntry Next; //Field offset: 0x10
		public CachedCodeEntry Previous; //Field offset: 0x18
		public readonly CachedCodeEntryKey Key; //Field offset: 0x20
		public RegexCode Code; //Field offset: 0x38
		public readonly Hashtable Caps; //Field offset: 0x40
		public readonly Hashtable Capnames; //Field offset: 0x48
		public readonly String[] Capslist; //Field offset: 0x50
		public readonly int Capsize; //Field offset: 0x58
		public readonly ExclusiveReference Runnerref; //Field offset: 0x60
		public readonly WeakReference<RegexReplacement> ReplRef; //Field offset: 0x68

		public CachedCodeEntry(CachedCodeEntryKey key, Hashtable capnames, String[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, WeakReference<RegexReplacement> replref) { }

	}

	[IsReadOnly]
	public struct CachedCodeEntryKey : IEquatable<CachedCodeEntryKey>
	{
		private readonly RegexOptions _options; //Field offset: 0x0
		private readonly string _cultureKey; //Field offset: 0x8
		private readonly string _pattern; //Field offset: 0x10

		public CachedCodeEntryKey(RegexOptions options, string cultureKey, string pattern) { }

		public virtual bool Equals(object obj) { }

		public override bool Equals(CachedCodeEntryKey other) { }

		public virtual int GetHashCode() { }

		public static bool op_Equality(CachedCodeEntryKey left, CachedCodeEntryKey right) { }

	}

	private const int CacheDictionarySwitchLimit = 10; //Field offset: 0x0
	private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT"; //Field offset: 0x0
	internal const int MaxOptionShift = 10; //Field offset: 0x0
	private static int s_cacheSize; //Field offset: 0x0
	private static readonly Dictionary<CachedCodeEntryKey, CachedCodeEntry> s_cache; //Field offset: 0x8
	private static int s_cacheCount; //Field offset: 0x10
	private static CachedCodeEntry s_cacheFirst; //Field offset: 0x18
	private static CachedCodeEntry s_cacheLast; //Field offset: 0x20
	private static readonly TimeSpan s_maximumMatchTimeout; //Field offset: 0x28
	internal static readonly TimeSpan s_defaultMatchTimeout; //Field offset: 0x30
	public static readonly TimeSpan InfiniteMatchTimeout; //Field offset: 0x38
	protected private TimeSpan internalMatchTimeout; //Field offset: 0x10
	protected private string pattern; //Field offset: 0x18
	protected private RegexOptions roptions; //Field offset: 0x20
	protected private RegexRunnerFactory factory; //Field offset: 0x28
	protected private Hashtable caps; //Field offset: 0x30
	protected private Hashtable capnames; //Field offset: 0x38
	protected private String[] capslist; //Field offset: 0x40
	protected private int capsize; //Field offset: 0x48
	internal ExclusiveReference _runnerref; //Field offset: 0x50
	internal WeakReference<RegexReplacement> _replref; //Field offset: 0x58
	internal RegexCode _code; //Field offset: 0x60
	internal bool _refsInitialized; //Field offset: 0x68

	public RegexOptions Options
	{
		 get { } //Length: 4
	}

	public bool RightToLeft
	{
		 get { } //Length: 8
	}

	private static Regex() { }

	protected Regex() { }

	public Regex(string pattern) { }

	public Regex(string pattern, RegexOptions options) { }

	private Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache) { }

	private void FillCacheDictionary() { }

	public RegexOptions get_Options() { }

	public bool get_RightToLeft() { }

	private CachedCodeEntry GetCachedCode(CachedCodeEntryKey key, bool isToAdd) { }

	private CachedCodeEntry GetCachedCodeEntryInternal(CachedCodeEntryKey key, bool isToAdd) { }

	public string GroupNameFromNumber(int i) { }

	public int GroupNumberFromName(string name) { }

	private static TimeSpan InitDefaultMatchTimeout() { }

	protected void InitializeReferences() { }

	public bool IsMatch(string input, int startat) { }

	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	public static bool IsMatch(string input, string pattern) { }

	public bool IsMatch(string input) { }

	private static CachedCodeEntry LookupCachedAndPromote(CachedCodeEntryKey key) { }

	public Match Match(string input, int startat) { }

	public Match Match(string input) { }

	public MatchCollection Matches(string input, int startat) { }

	private static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat) { }

	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	public string Replace(string input, MatchEvaluator evaluator) { }

	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	public static string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	public virtual string ToString() { }

	private static bool TryGetCacheValue(CachedCodeEntryKey key, out CachedCodeEntry entry) { }

	private static bool TryGetCacheValueSmall(CachedCodeEntryKey key, out CachedCodeEntry entry) { }

	internal bool UseOptionInvariant() { }

	protected private bool UseOptionR() { }

	protected private static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

}

