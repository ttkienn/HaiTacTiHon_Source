namespace System.Threading;

internal sealed class InternalThread : CriticalFinalizerObject
{
	private int lock_thread_id; //Field offset: 0x10
	private IntPtr handle; //Field offset: 0x18
	private IntPtr native_handle; //Field offset: 0x20
	private IntPtr name_chars; //Field offset: 0x28
	private int name_free; //Field offset: 0x30
	private int name_length; //Field offset: 0x34
	private ThreadState state; //Field offset: 0x38
	private object abort_exc; //Field offset: 0x40
	private int abort_state_handle; //Field offset: 0x48
	internal long thread_id; //Field offset: 0x50
	private IntPtr debugger_thread; //Field offset: 0x58
	private UIntPtr static_data; //Field offset: 0x60
	private IntPtr runtime_thread_info; //Field offset: 0x68
	private object current_appcontext; //Field offset: 0x70
	private object root_domain_thread; //Field offset: 0x78
	internal Byte[] _serialized_principal; //Field offset: 0x80
	internal int _serialized_principal_version; //Field offset: 0x88
	private IntPtr appdomain_refs; //Field offset: 0x90
	private int interruption_requested; //Field offset: 0x98
	private IntPtr longlived; //Field offset: 0xA0
	internal bool threadpool_thread; //Field offset: 0xA8
	private bool thread_interrupt_requested; //Field offset: 0xA9
	internal int stack_size; //Field offset: 0xAC
	internal byte apartment_state; //Field offset: 0xB0
	internal int critical_region_level; //Field offset: 0xB4
	internal int managed_id; //Field offset: 0xB8
	private int small_id; //Field offset: 0xBC
	private IntPtr manage_callback; //Field offset: 0xC0
	private IntPtr flags; //Field offset: 0xC8
	private IntPtr thread_pinning_ref; //Field offset: 0xD0
	private IntPtr abort_protected_block_count; //Field offset: 0xD8
	private int priority; //Field offset: 0xE0
	private IntPtr owned_mutex; //Field offset: 0xE8
	private IntPtr suspended_event; //Field offset: 0xF0
	private int self_suspended; //Field offset: 0xF8
	private IntPtr thread_state; //Field offset: 0x100
	private IntPtr netcore0; //Field offset: 0x108
	private IntPtr netcore1; //Field offset: 0x110
	private IntPtr netcore2; //Field offset: 0x118
	private IntPtr last; //Field offset: 0x120

	public InternalThread() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	protected virtual void Finalize() { }

	private void Thread_free_internal() { }

}

