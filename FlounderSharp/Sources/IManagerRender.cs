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
    /// <summary>A extension used with IRenderer's to define a master renderer.</summary>
    public unsafe abstract partial class IManagerRender : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr vfptr_IManagerRender;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0IManagerRender@fl@@QEAA@AEBV01@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??1IManagerRender@fl@@UEAA@XZ")]
            internal static extern void dtor(global::System.IntPtr instance, int delete);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::FlounderSharp.IManagerRender> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::FlounderSharp.IManagerRender>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::FlounderSharp.IManagerRender __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::FlounderSharp.IManagerRenderInternal(native.ToPointer(), skipVTables);
        }

        internal static global::FlounderSharp.IManagerRender __CreateInstance(global::FlounderSharp.IManagerRender.__Internal native, bool skipVTables = false)
        {
            return new global::FlounderSharp.IManagerRenderInternal(native, skipVTables);
        }

        protected IManagerRender(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
            if (skipVTables)
                __OriginalVTables = new void*[] { *(void**) (__Instance + 0) };
            else
                SetupVTables(true);
        }

        protected IManagerRender(global::FlounderSharp.IManagerRender _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.IManagerRender.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor((__Instance + __PointerAdjustment), __arg0);
            SetupVTables(GetType().FullName == "FlounderSharp.IManagerRender");
        }

        ~IManagerRender()
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
            global::FlounderSharp.IManagerRender __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            ((global::FlounderSharp.IManagerRender.__Internal*) __Instance)->vfptr_IManagerRender = new global::System.IntPtr(__OriginalVTables[0]);
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

        /// <summary>Run when rendering the master renderer.</summary>
        public abstract void Render();

        #region Virtual table interop

        // virtual ~IManagerRender()
        private static global::FlounderSharp.Delegates.Action_IntPtr_int _dtorDelegateInstance;

        private static void _dtorDelegateHook(global::System.IntPtr instance, int delete)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.IManagerRender) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.Dispose(true);
        }

        // void Render() = 0
        private static global::FlounderSharp.Delegates.Action_IntPtr _RenderDelegateInstance;

        private static void _RenderDelegateHook(global::System.IntPtr instance)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.IManagerRender) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.Render();
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
                _Thunks = new void*[2];
                _dtorDelegateInstance += _dtorDelegateHook;
                _Thunks[0] = Marshal.GetFunctionPointerForDelegate(_dtorDelegateInstance).ToPointer();
                _RenderDelegateInstance += _RenderDelegateHook;
                _Thunks[1] = Marshal.GetFunctionPointerForDelegate(_RenderDelegateInstance).ToPointer();
            }

            if (destructorOnly)
            {
                if (__ManagedVTablesDtorOnly == null)
                {
                    __ManagedVTablesDtorOnly = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(3 * 8);
                    __ManagedVTablesDtorOnly[0] = vfptr0.ToPointer();
                    *(void**) (vfptr0 + 0) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 0);
                    *(void**) (vfptr0 + 8) = _Thunks[0];
                    *(void**) (vfptr0 + 16) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 16);
                }

                *(void**) (__Instance + 0) = __ManagedVTablesDtorOnly[0];
            }
            else
            {
                if (__ManagedVTables == null)
                {
                    __ManagedVTables = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(3 * 8);
                    __ManagedVTables[0] = vfptr0.ToPointer();
                    *(void**) (vfptr0 + 0) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 0);
                    *(void**) (vfptr0 + 8) = _Thunks[0];
                    *(void**) (vfptr0 + 16) = _Thunks[1];
                }

                *(void**) (__Instance + 0) = __ManagedVTables[0];
            }
        }

        #endregion
    }

    public unsafe partial class IManagerRenderInternal : global::FlounderSharp.IManagerRender, IDisposable
    {
        private static void* __CopyValue(global::FlounderSharp.IManagerRender.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.IManagerRender.__Internal));
            *(global::FlounderSharp.IManagerRender.__Internal*) ret = native;
            return ret.ToPointer();
        }

        internal IManagerRenderInternal(global::FlounderSharp.IManagerRender.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        internal IManagerRenderInternal(void* native, bool skipVTables = false)
            : base((void*) null)
        {
            __PointerAdjustment = 0;
            __Instance = new global::System.IntPtr(native);
            __OriginalVTables = new void*[] { *(void**) (__Instance + 0) };
        }

        ~IManagerRenderInternal()
        {
            Dispose(false);
        }

        /// <summary>Run when rendering the master renderer.</summary>
        public override void Render()
        {
            var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 2 * 8);
            var ___RenderDelegate = (global::FlounderSharp.Delegates.Action_IntPtr) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Action_IntPtr));
            ___RenderDelegate((__Instance + __PointerAdjustment));
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