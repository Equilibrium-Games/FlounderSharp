// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FlounderSharp
{
    public unsafe partial class Buffer : global::FlounderSharp.IBuffer, IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr vfptr_Buffer;

            [FieldOffset(8)]
            internal ulong m_size;

            [FieldOffset(16)]
            internal global::System.IntPtr m_buffer;

            [FieldOffset(24)]
            internal global::System.IntPtr m_bufferMemory;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0Buffer@fl@@QEAA@AEB_KAEBI1@Z")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr instance, ulong* size, uint* usage, uint* properties);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0Buffer@fl@@QEAA@AEBV01@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?FindMemoryType@Buffer@fl@@SAIAEBI0@Z")]
            internal static extern uint FindMemoryType(uint* typeFilter, uint* properties);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?CopyBuffer@Buffer@fl@@SAXQEAUVkBuffer_T@@0AEB_K@Z")]
            internal static extern void CopyBuffer(global::System.IntPtr srcBuffer, global::System.IntPtr dstBuffer, ulong* size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetSize@Buffer@fl@@QEBA_KXZ")]
            internal static extern ulong GetSize(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetBuffer@Buffer@fl@@QEBAPEAUVkBuffer_T@@XZ")]
            internal static extern global::System.IntPtr GetBuffer(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetBufferMemory@Buffer@fl@@QEBAPEAUVkDeviceMemory_T@@XZ")]
            internal static extern global::System.IntPtr GetBufferMemory(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::FlounderSharp.IBuffer> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::FlounderSharp.IBuffer>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::FlounderSharp.Buffer __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::FlounderSharp.Buffer(native.ToPointer(), skipVTables);
        }

        internal static global::FlounderSharp.Buffer __CreateInstance(global::FlounderSharp.Buffer.__Internal native, bool skipVTables = false)
        {
            return new global::FlounderSharp.Buffer(native, skipVTables);
        }

        private static void* __CopyValue(global::FlounderSharp.Buffer.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.Buffer.__Internal));
            global::FlounderSharp.Buffer.__Internal.cctor(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private Buffer(global::FlounderSharp.Buffer.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Buffer(void* native, bool skipVTables = false)
        {
            __PointerAdjustment = 0;
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
            if (skipVTables)
                __OriginalVTables = new void*[] { *(void**) (__Instance + 0) };
            else
                SetupVTables(true);
        }

        public Buffer(ref ulong size, ref uint usage, ref uint properties)
            : this((void*) null)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.Buffer.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            fixed (ulong* __refParamPtr0 = &size)
            {
                var __arg0 = __refParamPtr0;
                fixed (uint* __refParamPtr1 = &usage)
                {
                    var __arg1 = __refParamPtr1;
                    fixed (uint* __refParamPtr2 = &properties)
                    {
                        var __arg2 = __refParamPtr2;
                        __Internal.ctor((__Instance), __arg0, __arg1, __arg2);
                    }
                }
            }
            SetupVTables(GetType().FullName == "FlounderSharp.Buffer");
        }

        public Buffer(global::FlounderSharp.IBuffer _0)
            : this((void*) null)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.Buffer.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__PointerToBuffer;
            __Internal.cctor((__Instance), __arg0);
            SetupVTables(GetType().FullName == "FlounderSharp.Buffer");
        }

        ~Buffer()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::FlounderSharp.IBuffer __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            ((global::FlounderSharp.Buffer.__Internal*) __Instance)->vfptr_Buffer = new global::System.IntPtr(__OriginalVTables[0]);
            if (disposing)
            {
                var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 1 * 8);
                var ___dtorDelegate = (global::FlounderSharp.Delegates.Action_IntPtr_int) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Action_IntPtr_int));
                ___dtorDelegate((__Instance), 0);
            }
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public static uint FindMemoryType(ref uint typeFilter, ref uint properties)
        {
            fixed (uint* __refParamPtr0 = &typeFilter)
            {
                var __arg0 = __refParamPtr0;
                fixed (uint* __refParamPtr1 = &properties)
                {
                    var __arg1 = __refParamPtr1;
                    var __ret = __Internal.FindMemoryType(__arg0, __arg1);
                    return __ret;
                }
            }
        }

        public static void CopyBuffer(global::VkBufferT srcBuffer, global::VkBufferT dstBuffer, ref ulong size)
        {
            var __arg0 = ReferenceEquals(srcBuffer, null) ? global::System.IntPtr.Zero : srcBuffer.__Instance;
            var __arg1 = ReferenceEquals(dstBuffer, null) ? global::System.IntPtr.Zero : dstBuffer.__Instance;
            fixed (ulong* __refParamPtr2 = &size)
            {
                var __arg2 = __refParamPtr2;
                __Internal.CopyBuffer(__arg0, __arg1, __arg2);
            }
        }

        protected ulong MSize
        {
            get
            {
                return ((global::FlounderSharp.Buffer.__Internal*) __Instance)->m_size;
            }

            set
            {
                ((global::FlounderSharp.Buffer.__Internal*)__Instance)->m_size = value;
            }
        }

        protected global::VkBufferT MBuffer
        {
            get
            {
                global::VkBufferT __result0;
                if (((global::FlounderSharp.Buffer.__Internal*) __Instance)->m_buffer == IntPtr.Zero) __result0 = null;
                else if (global::VkBufferT.NativeToManagedMap.ContainsKey(((global::FlounderSharp.Buffer.__Internal*) __Instance)->m_buffer))
                    __result0 = (global::VkBufferT) global::VkBufferT.NativeToManagedMap[((global::FlounderSharp.Buffer.__Internal*) __Instance)->m_buffer];
                else __result0 = global::VkBufferT.__CreateInstance(((global::FlounderSharp.Buffer.__Internal*) __Instance)->m_buffer);
                return __result0;
            }

            set
            {
                ((global::FlounderSharp.Buffer.__Internal*)__Instance)->m_buffer = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            }
        }

        protected global::VkDeviceMemoryT MBufferMemory
        {
            get
            {
                global::VkDeviceMemoryT __result0;
                if (((global::FlounderSharp.Buffer.__Internal*) __Instance)->m_bufferMemory == IntPtr.Zero) __result0 = null;
                else if (global::VkDeviceMemoryT.NativeToManagedMap.ContainsKey(((global::FlounderSharp.Buffer.__Internal*) __Instance)->m_bufferMemory))
                    __result0 = (global::VkDeviceMemoryT) global::VkDeviceMemoryT.NativeToManagedMap[((global::FlounderSharp.Buffer.__Internal*) __Instance)->m_bufferMemory];
                else __result0 = global::VkDeviceMemoryT.__CreateInstance(((global::FlounderSharp.Buffer.__Internal*) __Instance)->m_bufferMemory);
                return __result0;
            }

            set
            {
                ((global::FlounderSharp.Buffer.__Internal*)__Instance)->m_bufferMemory = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            }
        }

        public global::System.IntPtr __PointerToBuffer
        {
            get
            {
                return __Instance + 0;
            }
        }

        public ulong Size
        {
            get
            {
                var __ret = __Internal.GetSize((__Instance));
                return __ret;
            }
        }

        public global::VkBufferT Buffer
        {
            get
            {
                var __ret = __Internal.GetBuffer((__Instance));
                global::VkBufferT __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (global::VkBufferT.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (global::VkBufferT) global::VkBufferT.NativeToManagedMap[__ret];
                else __result0 = global::VkBufferT.__CreateInstance(__ret);
                return __result0;
            }
        }

        public global::VkDeviceMemoryT BufferMemory
        {
            get
            {
                var __ret = __Internal.GetBufferMemory((__Instance));
                global::VkDeviceMemoryT __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (global::VkDeviceMemoryT.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (global::VkDeviceMemoryT) global::VkDeviceMemoryT.NativeToManagedMap[__ret];
                else __result0 = global::VkDeviceMemoryT.__CreateInstance(__ret);
                return __result0;
            }
        }

        #region Virtual table interop

        // virtual ~Buffer()
        private static global::FlounderSharp.Delegates.Action_IntPtr_int _dtorDelegateInstance;

        private static void _dtorDelegateHook(global::System.IntPtr instance, int delete)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.Buffer) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.Dispose(true);
        }

        private static void*[] __ManagedVTables;
        private static void*[] __ManagedVTablesDtorOnly;
        private static void*[] _Thunks;

        private void SetupVTables(bool destructorOnly = false)
        {
            if (__OriginalVTables != null)
                return;
            __OriginalVTables = new void*[] { *(void**) (__Instance + 0) };

            if (_Thunks == null)
            {
                _Thunks = new void*[1];
                _dtorDelegateInstance += _dtorDelegateHook;
                _Thunks[0] = Marshal.GetFunctionPointerForDelegate(_dtorDelegateInstance).ToPointer();
            }

            if (destructorOnly)
            {
                if (__ManagedVTablesDtorOnly == null)
                {
                    __ManagedVTablesDtorOnly = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(2 * 8);
                    __ManagedVTablesDtorOnly[0] = vfptr0.ToPointer();
                    *(void**) (vfptr0 + 0) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 0);
                    *(void**) (vfptr0 + 8) = _Thunks[0];
                }

                *(void**) (__Instance + 0) = __ManagedVTablesDtorOnly[0];
            }
            else
            {
                if (__ManagedVTables == null)
                {
                    __ManagedVTables = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(2 * 8);
                    __ManagedVTables[0] = vfptr0.ToPointer();
                    *(void**) (vfptr0 + 0) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 0);
                    *(void**) (vfptr0 + 8) = _Thunks[0];
                }

                *(void**) (__Instance + 0) = __ManagedVTables[0];
            }
        }

        #endregion
    }

    public unsafe partial interface IBuffer : IDisposable
    {
        void Dispose();

        global::System.IntPtr __Instance { get; }

        global::System.IntPtr __PointerToBuffer { get; }

        ulong Size { get; }

        global::VkBufferT Buffer { get; }

        global::VkDeviceMemoryT BufferMemory { get; }
    }
}

namespace Std
{
    namespace Pair
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public unsafe partial struct __Internal_Ptr
        {
            [FieldOffset(0)]
            internal global::System.IntPtr first;

            [FieldOffset(8)]
            internal global::System.IntPtr second;
        }

        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public unsafe partial struct __Internalc__N_std_S_pair__1I____N_fl_S_FontCharacter
        {
            [FieldOffset(0)]
            internal int first;

            [FieldOffset(8)]
            internal global::System.IntPtr second;
        }

        [StructLayout(LayoutKind.Explicit, Size = 80)]
        public unsafe partial struct __Internalc__N_std_S_pair__1__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_fl_S_ConfigKey
        {
            [FieldOffset(0)]
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C first;

            [FieldOffset(32)]
            internal global::FlounderSharp.ConfigKey.__Internal second;
        }

        [StructLayout(LayoutKind.Explicit, Size = 40)]
        public unsafe partial struct __Internalc__N_std_S_pair____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C____N_fl_S_IModule
        {
            [FieldOffset(0)]
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C first;

            [FieldOffset(32)]
            internal global::System.IntPtr second;
        }

        [StructLayout(LayoutKind.Explicit, Size = 40)]
        public unsafe partial struct __Internalc__N_std_S_pair__1__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C____N_fl_S_JointTransform
        {
            [FieldOffset(0)]
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C first;

            [FieldOffset(32)]
            internal global::System.IntPtr second;
        }
    }
}