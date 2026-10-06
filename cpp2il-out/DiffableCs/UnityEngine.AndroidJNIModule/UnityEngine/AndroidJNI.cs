namespace UnityEngine;

[NativeConditional("PLATFORM_ANDROID")]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType::DoubleColon (2))]
public static class AndroidJNI
{

	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static long CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static sbyte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static short CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static long CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static sbyte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static short CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static void CallVoidMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	private static IntPtr ConvertToBooleanArray(Boolean[] array) { }

	[ThreadSafe]
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafe]
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	public static void ExceptionClear() { }

	[ThreadSafe]
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafe]
	public static IntPtr FindClass(string name) { }

	[ThreadSafe]
	public static Boolean[] FromBooleanArray(IntPtr array) { }

	[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
	[ThreadSafe]
	public static Byte[] FromByteArray(IntPtr array) { }

	[ThreadSafe]
	public static Char[] FromCharArray(IntPtr array) { }

	[ThreadSafe]
	public static Double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafe]
	public static Single[] FromFloatArray(IntPtr array) { }

	[ThreadSafe]
	public static Int32[] FromIntArray(IntPtr array) { }

	[ThreadSafe]
	public static Int64[] FromLongArray(IntPtr array) { }

	[ThreadSafe]
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafe]
	public static SByte[] FromSByteArray(IntPtr array) { }

	[ThreadSafe]
	public static Int16[] FromShortArray(IntPtr array) { }

	[ThreadSafe]
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafe]
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafe]
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	public static string GetStringChars(IntPtr str) { }

	[ThreadSafe]
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2) { }

	[ThreadSafe]
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	public static IntPtr NewLocalRef(IntPtr obj) { }

	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	public static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	public static IntPtr NewString(string chars) { }

	[ThreadSafe]
	private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafe]
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	public static IntPtr PopLocalFrame(IntPtr ptr) { }

	[ThreadSafe]
	public static int PushLocalFrame(int capacity) { }

	[ThreadSafe]
	internal static void QueueDeleteGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

	public static IntPtr ToBooleanArray(Boolean[] array) { }

	[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
	[ThreadSafe]
	public static IntPtr ToByteArray(Byte[] array) { }

	public static IntPtr ToCharArray(Char[] array) { }

	[ThreadSafe]
	public static IntPtr ToCharArray(Char* array, int length) { }

	public static IntPtr ToDoubleArray(Double[] array) { }

	[ThreadSafe]
	public static IntPtr ToDoubleArray(Double* array, int length) { }

	public static IntPtr ToFloatArray(Single[] array) { }

	[ThreadSafe]
	public static IntPtr ToFloatArray(Single* array, int length) { }

	[ThreadSafe]
	public static IntPtr ToIntArray(Int32* array, int length) { }

	public static IntPtr ToIntArray(Int32[] array) { }

	public static IntPtr ToLongArray(Int64[] array) { }

	[ThreadSafe]
	public static IntPtr ToLongArray(Int64* array, int length) { }

	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[ThreadSafe]
	public static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass) { }

	[ThreadSafe]
	public static IntPtr ToSByteArray(SByte* array, int length) { }

	public static IntPtr ToSByteArray(SByte[] array) { }

	[ThreadSafe]
	public static IntPtr ToShortArray(Int16* array, int length) { }

	public static IntPtr ToShortArray(Int16[] array) { }

}

