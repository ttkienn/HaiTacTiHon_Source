namespace Mono.Unity;

internal static class UnityTls
{
	internal enum unitytls_ciphersuite
	{
		UNITYTLS_CIPHERSUITE_INVALID = 16777215,
	}

	internal enum unitytls_error_code
	{
		UNITYTLS_SUCCESS = 0,
		UNITYTLS_INVALID_ARGUMENT = 1,
		UNITYTLS_INVALID_FORMAT = 2,
		UNITYTLS_INVALID_PASSWORD = 3,
		UNITYTLS_INVALID_STATE = 4,
		UNITYTLS_BUFFER_OVERFLOW = 5,
		UNITYTLS_OUT_OF_MEMORY = 6,
		UNITYTLS_INTERNAL_ERROR = 7,
		UNITYTLS_NOT_SUPPORTED = 8,
		UNITYTLS_ENTROPY_SOURCE_FAILED = 9,
		UNITYTLS_STREAM_CLOSED = 10,
		UNITYTLS_USER_CUSTOM_ERROR_START = 1048576,
		UNITYTLS_USER_WOULD_BLOCK = 1048577,
		UNITYTLS_USER_READ_FAILED = 1048578,
		UNITYTLS_USER_WRITE_FAILED = 1048579,
		UNITYTLS_USER_UNKNOWN_ERROR = 1048580,
		UNITYTLS_USER_CUSTOM_ERROR_END = 2097152,
	}

	internal struct unitytls_errorstate
	{
		private uint magic; //Field offset: 0x0
		public unitytls_error_code code; //Field offset: 0x4
		private ulong reserved; //Field offset: 0x8

	}

	internal class unitytls_interface_struct
	{
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_errorstate_create_t : MulticastDelegate
		{

			public unitytls_errorstate_create_t(object object, IntPtr method) { }

			public override unitytls_errorstate Invoke() { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_errorstate_raise_error_t : MulticastDelegate
		{

			public unitytls_errorstate_raise_error_t(object object, IntPtr method) { }

			public override void Invoke(unitytls_errorstate* errorState, unitytls_error_code errorCode) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_key_free_t : MulticastDelegate
		{

			public unitytls_key_free_t(object object, IntPtr method) { }

			public override void Invoke(unitytls_key* key) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_key_get_ref_t : MulticastDelegate
		{

			public unitytls_key_get_ref_t(object object, IntPtr method) { }

			public override unitytls_key_ref Invoke(unitytls_key* key, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_key_parse_der_t : MulticastDelegate
		{

			public unitytls_key_parse_der_t(object object, IntPtr method) { }

			public override unitytls_key* Invoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_key_parse_pem_t : MulticastDelegate
		{

			public unitytls_key_parse_pem_t(object object, IntPtr method) { }

			public override unitytls_key* Invoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_random_generate_bytes_t : MulticastDelegate
		{

			public unitytls_random_generate_bytes_t(object object, IntPtr method) { }

			public override void Invoke(Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_create_client_t : MulticastDelegate
		{

			public unitytls_tlsctx_create_client_t(object object, IntPtr method) { }

			public override unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, Byte* cn, IntPtr cnLen, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_create_server_t : MulticastDelegate
		{

			public unitytls_tlsctx_create_server_t(object object, IntPtr method) { }

			public override unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_free_t : MulticastDelegate
		{

			public unitytls_tlsctx_free_t(object object, IntPtr method) { }

			public override void Invoke(unitytls_tlsctx* ctx) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_get_ciphersuite_t : MulticastDelegate
		{

			public unitytls_tlsctx_get_ciphersuite_t(object object, IntPtr method) { }

			public override unitytls_ciphersuite Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_get_protocol_t : MulticastDelegate
		{

			public unitytls_tlsctx_get_protocol_t(object object, IntPtr method) { }

			public override unitytls_protocol Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_notify_close_t : MulticastDelegate
		{

			public unitytls_tlsctx_notify_close_t(object object, IntPtr method) { }

			public override void Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_process_handshake_t : MulticastDelegate
		{

			public unitytls_tlsctx_process_handshake_t(object object, IntPtr method) { }

			public override unitytls_x509verify_result Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_read_t : MulticastDelegate
		{

			public unitytls_tlsctx_read_t(object object, IntPtr method) { }

			public override IntPtr Invoke(unitytls_tlsctx* ctx, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_server_require_client_authentication_t : MulticastDelegate
		{

			public unitytls_tlsctx_server_require_client_authentication_t(object object, IntPtr method) { }

			public override void Invoke(unitytls_tlsctx* ctx, unitytls_x509list_ref clientAuthCAList, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_set_certificate_callback_t : MulticastDelegate
		{

			public unitytls_tlsctx_set_certificate_callback_t(object object, IntPtr method) { }

			public override void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_certificate_callback cb, Void* userData, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_set_supported_ciphersuites_t : MulticastDelegate
		{

			public unitytls_tlsctx_set_supported_ciphersuites_t(object object, IntPtr method) { }

			public override void Invoke(unitytls_tlsctx* ctx, unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_set_trace_callback_t : MulticastDelegate
		{

			public unitytls_tlsctx_set_trace_callback_t(object object, IntPtr method) { }

			public override void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_trace_callback cb, Void* userData, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_set_x509verify_callback_t : MulticastDelegate
		{

			public unitytls_tlsctx_set_x509verify_callback_t(object object, IntPtr method) { }

			public override void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_write_t : MulticastDelegate
		{

			public unitytls_tlsctx_write_t(object object, IntPtr method) { }

			public override IntPtr Invoke(unitytls_tlsctx* ctx, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509_export_der_t : MulticastDelegate
		{

			public unitytls_x509_export_der_t(object object, IntPtr method) { }

			public override IntPtr Invoke(unitytls_x509_ref cert, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509list_append_der_t : MulticastDelegate
		{

			public unitytls_x509list_append_der_t(object object, IntPtr method) { }

			public override void Invoke(unitytls_x509list* list, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509list_append_t : MulticastDelegate
		{

			public unitytls_x509list_append_t(object object, IntPtr method) { }

			public override void Invoke(unitytls_x509list* list, unitytls_x509_ref cert, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509list_create_t : MulticastDelegate
		{

			public unitytls_x509list_create_t(object object, IntPtr method) { }

			public override unitytls_x509list* Invoke(unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509list_free_t : MulticastDelegate
		{

			public unitytls_x509list_free_t(object object, IntPtr method) { }

			public override void Invoke(unitytls_x509list* list) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509list_get_ref_t : MulticastDelegate
		{

			public unitytls_x509list_get_ref_t(object object, IntPtr method) { }

			public override unitytls_x509list_ref Invoke(unitytls_x509list* list, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509list_get_x509_t : MulticastDelegate
		{

			public unitytls_x509list_get_x509_t(object object, IntPtr method) { }

			public override unitytls_x509_ref Invoke(unitytls_x509list_ref list, IntPtr index, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509verify_default_ca_t : MulticastDelegate
		{

			public unitytls_x509verify_default_ca_t(object object, IntPtr method) { }

			public override unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509verify_explicit_ca_t : MulticastDelegate
		{

			public unitytls_x509verify_explicit_ca_t(object object, IntPtr method) { }

			public override unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, unitytls_x509list_ref trustCA, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

		}

		public readonly ulong UNITYTLS_INVALID_HANDLE; //Field offset: 0x10
		public readonly unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT; //Field offset: 0x18
		public unitytls_errorstate_create_t unitytls_errorstate_create; //Field offset: 0x20
		public unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error; //Field offset: 0x28
		public unitytls_key_get_ref_t unitytls_key_get_ref; //Field offset: 0x30
		public unitytls_key_parse_der_t unitytls_key_parse_der; //Field offset: 0x38
		public unitytls_key_parse_pem_t unitytls_key_parse_pem; //Field offset: 0x40
		public unitytls_key_free_t unitytls_key_free; //Field offset: 0x48
		public unitytls_x509_export_der_t unitytls_x509_export_der; //Field offset: 0x50
		public unitytls_x509list_get_ref_t unitytls_x509list_get_ref; //Field offset: 0x58
		public unitytls_x509list_get_x509_t unitytls_x509list_get_x509; //Field offset: 0x60
		public unitytls_x509list_create_t unitytls_x509list_create; //Field offset: 0x68
		public unitytls_x509list_append_t unitytls_x509list_append; //Field offset: 0x70
		public unitytls_x509list_append_der_t unitytls_x509list_append_der; //Field offset: 0x78
		public unitytls_x509list_append_der_t unitytls_x509list_append_pem; //Field offset: 0x80
		public unitytls_x509list_free_t unitytls_x509list_free; //Field offset: 0x88
		public unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca; //Field offset: 0x90
		public unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca; //Field offset: 0x98
		public unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server; //Field offset: 0xA0
		public unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client; //Field offset: 0xA8
		public unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication; //Field offset: 0xB0
		public unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback; //Field offset: 0xB8
		public unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback; //Field offset: 0xC0
		public unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback; //Field offset: 0xC8
		public unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites; //Field offset: 0xD0
		public unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite; //Field offset: 0xD8
		public unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol; //Field offset: 0xE0
		public unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake; //Field offset: 0xE8
		public unitytls_tlsctx_read_t unitytls_tlsctx_read; //Field offset: 0xF0
		public unitytls_tlsctx_write_t unitytls_tlsctx_write; //Field offset: 0xF8
		public unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close; //Field offset: 0x100
		public unitytls_tlsctx_free_t unitytls_tlsctx_free; //Field offset: 0x108
		public unitytls_random_generate_bytes_t unitytls_random_generate_bytes; //Field offset: 0x110

		public unitytls_interface_struct() { }

	}

	internal struct unitytls_key
	{

	}

	internal struct unitytls_key_ref
	{
		public ulong handle; //Field offset: 0x0

	}

	internal enum unitytls_protocol
	{
		UNITYTLS_PROTOCOL_TLS_1_0 = 0,
		UNITYTLS_PROTOCOL_TLS_1_1 = 1,
		UNITYTLS_PROTOCOL_TLS_1_2 = 2,
		UNITYTLS_PROTOCOL_INVALID = 3,
	}

	internal struct unitytls_tlsctx
	{

	}

	internal struct unitytls_tlsctx_callbacks
	{
		public unitytls_tlsctx_read_callback read; //Field offset: 0x0
		public unitytls_tlsctx_write_callback write; //Field offset: 0x8
		public Void* data; //Field offset: 0x10

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class unitytls_tlsctx_certificate_callback : MulticastDelegate
	{

		public unitytls_tlsctx_certificate_callback(object object, IntPtr method) { }

		public override void Invoke(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	}

	internal struct unitytls_tlsctx_protocolrange
	{
		public unitytls_protocol min; //Field offset: 0x0
		public unitytls_protocol max; //Field offset: 0x4

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class unitytls_tlsctx_read_callback : MulticastDelegate
	{

		public unitytls_tlsctx_read_callback(object object, IntPtr method) { }

		public override IntPtr Invoke(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class unitytls_tlsctx_trace_callback : MulticastDelegate
	{

		public unitytls_tlsctx_trace_callback(object object, IntPtr method) { }

		public override void Invoke(Void* userData, unitytls_tlsctx* ctx, Byte* traceMessage, IntPtr traceMessageLen) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class unitytls_tlsctx_write_callback : MulticastDelegate
	{

		public unitytls_tlsctx_write_callback(object object, IntPtr method) { }

		public override IntPtr Invoke(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class unitytls_tlsctx_x509verify_callback : MulticastDelegate
	{

		public unitytls_tlsctx_x509verify_callback(object object, IntPtr method) { }

		public override unitytls_x509verify_result Invoke(Void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	}

	internal struct unitytls_x509_ref
	{
		public ulong handle; //Field offset: 0x0

	}

	internal struct unitytls_x509list
	{

	}

	internal struct unitytls_x509list_ref
	{
		public ulong handle; //Field offset: 0x0

	}

	internal struct unitytls_x509name
	{

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class unitytls_x509verify_callback : MulticastDelegate
	{

		public unitytls_x509verify_callback(object object, IntPtr method) { }

		public override unitytls_x509verify_result Invoke(Void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState) { }

	}

	[Flags]
	internal enum unitytls_x509verify_result
	{
		UNITYTLS_X509VERIFY_SUCCESS = 0,
		UNITYTLS_X509VERIFY_NOT_DONE = 2147483648,
		UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295,
		UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1,
		UNITYTLS_X509VERIFY_FLAG_REVOKED = 2,
		UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4,
		UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608,
		UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728,
	}

	private static unitytls_interface_struct marshalledInterface; //Field offset: 0x0

	public static bool IsSupported
	{
		 get { } //Length: 22
	}

	public static unitytls_interface_struct NativeInterface
	{
		 get { } //Length: 220
	}

	public static bool get_IsSupported() { }

	public static unitytls_interface_struct get_NativeInterface() { }

	private static IntPtr GetUnityTlsInterface() { }

}

