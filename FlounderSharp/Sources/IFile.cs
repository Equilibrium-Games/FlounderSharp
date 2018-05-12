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
    public unsafe abstract partial class IFile : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr vfptr_IFile;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0IFile@fl@@QEAA@AEBV01@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0IFile@fl@@QEAA@XZ")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??1IFile@fl@@UEAA@XZ")]
            internal static extern void dtor(global::System.IntPtr instance, int delete);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::FlounderSharp.IFile> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::FlounderSharp.IFile>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::FlounderSharp.IFile __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::FlounderSharp.IFileInternal(native.ToPointer(), skipVTables);
        }

        internal static global::FlounderSharp.IFile __CreateInstance(global::FlounderSharp.IFile.__Internal native, bool skipVTables = false)
        {
            return new global::FlounderSharp.IFileInternal(native, skipVTables);
        }

        protected IFile(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
            if (skipVTables)
                __OriginalVTables = new void*[] { *(void**) (__Instance + 0) };
            else
                SetupVTables(true);
        }

        protected IFile(global::FlounderSharp.IFile _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.IFile.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor((__Instance + __PointerAdjustment), __arg0);
            SetupVTables(GetType().FullName == "FlounderSharp.IFile");
        }

        protected IFile()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.IFile.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor((__Instance + __PointerAdjustment));
            SetupVTables(GetType().FullName == "FlounderSharp.IFile");
        }

        ~IFile()
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
            global::FlounderSharp.IFile __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            ((global::FlounderSharp.IFile.__Internal*) __Instance)->vfptr_IFile = new global::System.IntPtr(__OriginalVTables[0]);
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

        public abstract void Load();

        public abstract void Save();

        public abstract void Clear();

        public abstract void ConfigPushValue(string key, string value);

        #region Virtual table interop

        // virtual ~IFile() { }
        private static global::FlounderSharp.Delegates.Action_IntPtr_int _dtorDelegateInstance;

        private static void _dtorDelegateHook(global::System.IntPtr instance, int delete)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.IFile) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.Dispose(true);
        }

        // void Load() = 0
        private static global::FlounderSharp.Delegates.Action_IntPtr _LoadDelegateInstance;

        private static void _LoadDelegateHook(global::System.IntPtr instance)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.IFile) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.Load();
        }

        // void Save() = 0
        private static global::FlounderSharp.Delegates.Action_IntPtr _SaveDelegateInstance;

        private static void _SaveDelegateHook(global::System.IntPtr instance)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.IFile) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.Save();
        }

        // void Clear() = 0
        private static global::FlounderSharp.Delegates.Action_IntPtr _ClearDelegateInstance;

        private static void _ClearDelegateHook(global::System.IntPtr instance)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.IFile) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.Clear();
        }

        // void ConfigPushValue(const std::string &key, const std::string &value) = 0
        private static global::FlounderSharp.Delegates.Action_IntPtr_IntPtr_IntPtr _ConfigPushValueDelegateInstance;

        private static void _ConfigPushValueDelegateHook(global::System.IntPtr instance, global::System.IntPtr key, global::System.IntPtr value)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.IFile) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            var __basicStringRet = global::Std.BasicString<char, global::Std.CharTraits<char>, global::Std.Allocator<char>>.__CreateInstance(key);
            var __basicStringRet = global::Std.BasicString<char, global::Std.CharTraits<char>, global::Std.Allocator<char>>.__CreateInstance(value);
            __target.ConfigPushValue(global::Std.BasicStringExtensions.CStr(__basicStringRet), global::Std.BasicStringExtensions.CStr(__basicStringRet));
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
                _Thunks = new void*[5];
                _dtorDelegateInstance += _dtorDelegateHook;
                _Thunks[0] = Marshal.GetFunctionPointerForDelegate(_dtorDelegateInstance).ToPointer();
                _LoadDelegateInstance += _LoadDelegateHook;
                _Thunks[1] = Marshal.GetFunctionPointerForDelegate(_LoadDelegateInstance).ToPointer();
                _SaveDelegateInstance += _SaveDelegateHook;
                _Thunks[2] = Marshal.GetFunctionPointerForDelegate(_SaveDelegateInstance).ToPointer();
                _ClearDelegateInstance += _ClearDelegateHook;
                _Thunks[3] = Marshal.GetFunctionPointerForDelegate(_ClearDelegateInstance).ToPointer();
                _ConfigPushValueDelegateInstance += _ConfigPushValueDelegateHook;
                _Thunks[4] = Marshal.GetFunctionPointerForDelegate(_ConfigPushValueDelegateInstance).ToPointer();
            }

            if (destructorOnly)
            {
                if (__ManagedVTablesDtorOnly == null)
                {
                    __ManagedVTablesDtorOnly = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(7 * 8);
                    __ManagedVTablesDtorOnly[0] = vfptr0.ToPointer();
                    *(void**) (vfptr0 + 0) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 0);
                    *(void**) (vfptr0 + 8) = _Thunks[0];
                    *(void**) (vfptr0 + 16) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 16);
                    *(void**) (vfptr0 + 24) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 24);
                    *(void**) (vfptr0 + 32) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 32);
                    *(void**) (vfptr0 + 40) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 40);
                    *(void**) (vfptr0 + 48) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 48);
                }

                *(void**) (__Instance + 0) = __ManagedVTablesDtorOnly[0];
            }
            else
            {
                if (__ManagedVTables == null)
                {
                    __ManagedVTables = new void*[1];
                    var vfptr0 = Marshal.AllocHGlobal(7 * 8);
                    __ManagedVTables[0] = vfptr0.ToPointer();
                    *(void**) (vfptr0 + 0) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 0);
                    *(void**) (vfptr0 + 8) = _Thunks[0];
                    *(void**) (vfptr0 + 16) = _Thunks[1];
                    *(void**) (vfptr0 + 24) = _Thunks[2];
                    *(void**) (vfptr0 + 32) = _Thunks[3];
                    *(void**) (vfptr0 + 40) = *(void**) (new IntPtr(*(void**) __Instance) + 0 + 40);
                    *(void**) (vfptr0 + 48) = _Thunks[4];
                }

                *(void**) (__Instance + 0) = __ManagedVTables[0];
            }
        }

        #endregion
    }

    public unsafe partial class IFileInternal : global::FlounderSharp.IFile, IDisposable
    {
        private static void* __CopyValue(global::FlounderSharp.IFile.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.IFile.__Internal));
            *(global::FlounderSharp.IFile.__Internal*) ret = native;
            return ret.ToPointer();
        }

        internal IFileInternal(global::FlounderSharp.IFile.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        internal IFileInternal(void* native, bool skipVTables = false)
            : base((void*) null)
        {
            __PointerAdjustment = 0;
            __Instance = new global::System.IntPtr(native);
            __OriginalVTables = new void*[] { *(void**) (__Instance + 0) };
        }

        ~IFileInternal()
        {
            Dispose(false);
        }

        public override void Load()
        {
            var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 2 * 8);
            var ___LoadDelegate = (global::FlounderSharp.Delegates.Action_IntPtr) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Action_IntPtr));
            ___LoadDelegate((__Instance + __PointerAdjustment));
        }

        public override void Save()
        {
            var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 3 * 8);
            var ___SaveDelegate = (global::FlounderSharp.Delegates.Action_IntPtr) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Action_IntPtr));
            ___SaveDelegate((__Instance + __PointerAdjustment));
        }

        public override void Clear()
        {
            var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 4 * 8);
            var ___ClearDelegate = (global::FlounderSharp.Delegates.Action_IntPtr) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Action_IntPtr));
            ___ClearDelegate((__Instance + __PointerAdjustment));
        }

        public override void ConfigPushValue(string key, string value)
        {
            var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 6 * 8);
            var ___ConfigPushValueDelegate = (global::FlounderSharp.Delegates.Action_IntPtr_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Action_IntPtr_IntPtr_IntPtr));
            var __allocator0 = new global::Std.Allocator<char>();
            var __basicString0 = global::Std.BasicStringExtensions.BasicString(key, __allocator0);
            var __arg0 = __basicString0.__Instance;
            var __allocator1 = new global::Std.Allocator<char>();
            var __basicString1 = global::Std.BasicStringExtensions.BasicString(value, __allocator1);
            var __arg1 = __basicString1.__Instance;
            ___ConfigPushValueDelegate((__Instance + __PointerAdjustment), __arg0, __arg1);
            __basicString0.Dispose(false);
            __allocator0.Dispose();
            __basicString1.Dispose(false);
            __allocator1.Dispose();
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