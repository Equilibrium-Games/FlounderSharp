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
    public unsafe abstract partial class IVertex : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr vfptr_IVertex;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0IVertex@fl@@QEAA@XZ")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0IVertex@fl@@QEAA@AEBV01@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??1IVertex@fl@@UEAA@XZ")]
            internal static extern void dtor(global::System.IntPtr instance, int delete);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::FlounderSharp.IVertex> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::FlounderSharp.IVertex>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::FlounderSharp.IVertex __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::FlounderSharp.IVertexInternal(native.ToPointer(), skipVTables);
        }

        internal static global::FlounderSharp.IVertex __CreateInstance(global::FlounderSharp.IVertex.__Internal native, bool skipVTables = false)
        {
            return new global::FlounderSharp.IVertexInternal(native, skipVTables);
        }

        protected IVertex(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
            if (skipVTables)
                __OriginalVTables = new void*[] { *(void**) (__Instance + 0) };
            else
                SetupVTables(true);
        }

        protected IVertex()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.IVertex.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor((__Instance + __PointerAdjustment));
            SetupVTables(GetType().FullName == "FlounderSharp.IVertex");
        }

        protected IVertex(global::FlounderSharp.IVertex _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.IVertex.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor((__Instance + __PointerAdjustment), __arg0);
            SetupVTables(GetType().FullName == "FlounderSharp.IVertex");
        }

        ~IVertex()
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
            global::FlounderSharp.IVertex __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            ((global::FlounderSharp.IVertex.__Internal*) __Instance)->vfptr_IVertex = new global::System.IntPtr(__OriginalVTables[0]);
            if (disposing)
            {
                var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 1 * 8);
                if (__slot != null)
                {
                    var ___dtorDelegate = (global::FlounderSharp.Delegates.Action_IntPtr_int) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Action_IntPtr_int));
                    ___dtorDelegate((__Instance + __PointerAdjustment), 0);
                }
                else
                    __Internal.dtor((__Instance + __PointerAdjustment), 0);
            }
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public abstract global::FlounderSharp.Vector3 Position
        {
            get;

            set;
        }

        public abstract ulong Size
        {
            get;
        }

        #region Virtual table interop

        // virtual ~IVertex() { }
        private static global::FlounderSharp.Delegates.Action_IntPtr_int _dtorDelegateInstance;

        private static void _dtorDelegateHook(global::System.IntPtr instance, int delete)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.IVertex) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.Dispose(true);
        }

        // Vector3 GetPosition() const = 0
        private static global::FlounderSharp.Delegates.Action_IntPtr_IntPtr _GetPositionDelegateInstance;

        private static void _GetPositionDelegateHook(global::System.IntPtr instance, global::System.IntPtr @return)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.IVertex) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            var __ret = __target.Position;
            *(global::FlounderSharp.Vector3.__Internal*) @return = ReferenceEquals(__ret, null) ? new global::FlounderSharp.Vector3.__Internal() : *(global::FlounderSharp.Vector3.__Internal*) __ret.__Instance;
        }

        // void SetPosition(const Vector3 &position) = 0
        private static global::FlounderSharp.Delegates.Action_IntPtr_IntPtr _SetPositionDelegateInstance;

        private static void _SetPositionDelegateHook(global::System.IntPtr instance, global::System.IntPtr position)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.IVertex) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::FlounderSharp.Vector3 __result0;
            if (position == IntPtr.Zero) __result0 = null;
            else if (global::FlounderSharp.Vector3.NativeToManagedMap.ContainsKey(position))
                __result0 = (global::FlounderSharp.Vector3) global::FlounderSharp.Vector3.NativeToManagedMap[position];
            else __result0 = global::FlounderSharp.Vector3.__CreateInstance(position);
            __target.Position = __result0;
        }

        // size_t GetSize() const = 0
        private static global::FlounderSharp.Delegates.Func_ulong_IntPtr _GetSizeDelegateInstance;

        private static ulong _GetSizeDelegateHook(global::System.IntPtr instance)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.IVertex) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            var __ret = __target.Size;
            return __ret;
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
                _Thunks = new void*[4];
                _dtorDelegateInstance += _dtorDelegateHook;
                _Thunks[0] = Marshal.GetFunctionPointerForDelegate(_dtorDelegateInstance).ToPointer();
                _GetPositionDelegateInstance += _GetPositionDelegateHook;
                _Thunks[1] = Marshal.GetFunctionPointerForDelegate(_GetPositionDelegateInstance).ToPointer();
                _SetPositionDelegateInstance += _SetPositionDelegateHook;
                _Thunks[2] = Marshal.GetFunctionPointerForDelegate(_SetPositionDelegateInstance).ToPointer();
                _GetSizeDelegateInstance += _GetSizeDelegateHook;
                _Thunks[3] = Marshal.GetFunctionPointerForDelegate(_GetSizeDelegateInstance).ToPointer();
            }

            if (destructorOnly)
            {
                if (__ManagedVTablesDtorOnly == null)
                {
                    __ManagedVTablesDtorOnly = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(6 * 8);
                    __ManagedVTablesDtorOnly[0] = vfptr0.ToPointer();
                    *(void**) (vfptr0 + 0) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 0);
                    *(void**) (vfptr0 + 8) = _Thunks[0];
                    *(void**) (vfptr0 + 16) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 16);
                    *(void**) (vfptr0 + 24) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 24);
                    *(void**) (vfptr0 + 32) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 32);
                    *(void**) (vfptr0 + 40) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 40);
                }

                *(void**) (__Instance + 0) = __ManagedVTablesDtorOnly[0];
            }
            else
            {
                if (__ManagedVTables == null)
                {
                    __ManagedVTables = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(6 * 8);
                    __ManagedVTables[0] = vfptr0.ToPointer();
                    *(void**) (vfptr0 + 0) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 0);
                    *(void**) (vfptr0 + 8) = _Thunks[0];
                    *(void**) (vfptr0 + 16) = _Thunks[1];
                    *(void**) (vfptr0 + 24) = _Thunks[2];
                    *(void**) (vfptr0 + 32) = _Thunks[3];
                    *(void**) (vfptr0 + 40) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 40);
                }

                *(void**) (__Instance + 0) = __ManagedVTables[0];
            }
        }

        #endregion
    }

    public unsafe partial class IVertexInternal : global::FlounderSharp.IVertex, IDisposable
    {
        private static void* __CopyValue(global::FlounderSharp.IVertex.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.IVertex.__Internal));
            *(global::FlounderSharp.IVertex.__Internal*) ret = native;
            return ret.ToPointer();
        }

        internal IVertexInternal(global::FlounderSharp.IVertex.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        internal IVertexInternal(void* native, bool skipVTables = false)
            : base((void*) null)
        {
            __PointerAdjustment = 0;
            __Instance = new global::System.IntPtr(native);
            __OriginalVTables = new void*[] { *(void**) (__Instance + 0) };
        }

        ~IVertexInternal()
        {
            Dispose(false);
        }

        public override global::FlounderSharp.Vector3 Position
        {
            get
            {
                var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 2 * 8);
                var ___GetPositionDelegate = (global::FlounderSharp.Delegates.Action_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Action_IntPtr_IntPtr));
                var __ret = new global::FlounderSharp.Vector3.__Internal();
                ___GetPositionDelegate((__Instance + __PointerAdjustment), new IntPtr(&__ret));
                return global::FlounderSharp.Vector3.__CreateInstance(__ret);
            }

            set
            {
                var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 3 * 8);
                var ___SetPositionDelegate = (global::FlounderSharp.Delegates.Action_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Action_IntPtr_IntPtr));
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is a C++ reference (&).");
                var __arg0 = value.__Instance;
                ___SetPositionDelegate((__Instance + __PointerAdjustment), __arg0);
            }
        }

        public override ulong Size
        {
            get
            {
                var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 4 * 8);
                var ___GetSizeDelegate = (global::FlounderSharp.Delegates.Func_ulong_IntPtr) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Func_ulong_IntPtr));
                var __ret = ___GetSizeDelegate((__Instance + __PointerAdjustment));
                return __ret;
            }
        }
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