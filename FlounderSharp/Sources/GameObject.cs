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
    public unsafe partial class GameObject : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 72)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr vfptr_GameObject;

            [FieldOffset(8)]
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C m_name;

            [FieldOffset(40)]
            internal global::System.IntPtr m_transform;

            [FieldOffset(48)]
            internal global::System.IntPtr m_components;

            [FieldOffset(56)]
            internal global::System.IntPtr m_structure;

            [FieldOffset(64)]
            internal byte m_removed;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0GameObject@fl@@QEAA@AEBV01@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?AddComponent@GameObject@fl@@QEAAPEAVComponent@2@PEAV32@@Z")]
            internal static extern global::System.IntPtr AddComponent(global::System.IntPtr instance, global::System.IntPtr component);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?RemoveComponent@GameObject@fl@@QEAAPEAVComponent@2@PEAV32@@Z")]
            internal static extern global::System.IntPtr RemoveComponent(global::System.IntPtr instance, global::System.IntPtr component);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?StructureRemove@GameObject@fl@@QEAAXXZ")]
            internal static extern void StructureRemove(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetName@GameObject@fl@@QEBA?AV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@XZ")]
            internal static extern void GetName(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?SetName@GameObject@fl@@QEAAXAEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@Z")]
            internal static extern void SetName(global::System.IntPtr instance, global::System.IntPtr name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetTransform@GameObject@fl@@QEBAPEAVTransform@2@XZ")]
            internal static extern global::System.IntPtr GetTransform(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?SetTransform@GameObject@fl@@QEBAXAEBVTransform@2@@Z")]
            internal static extern void SetTransform(global::System.IntPtr instance, global::System.IntPtr transform);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetRemoved@GameObject@fl@@QEBA_NXZ")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool GetRemoved(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::FlounderSharp.GameObject> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::FlounderSharp.GameObject>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::FlounderSharp.GameObject __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::FlounderSharp.GameObject(native.ToPointer(), skipVTables);
        }

        internal static global::FlounderSharp.GameObject __CreateInstance(global::FlounderSharp.GameObject.__Internal native, bool skipVTables = false)
        {
            return new global::FlounderSharp.GameObject(native, skipVTables);
        }

        private static void* __CopyValue(global::FlounderSharp.GameObject.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.GameObject.__Internal));
            global::FlounderSharp.GameObject.__Internal.cctor(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private GameObject(global::FlounderSharp.GameObject.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected GameObject(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
            if (skipVTables)
                __OriginalVTables = new void*[] { *(void**) (__Instance + 0) };
            else
                SetupVTables(true);
        }

        public GameObject(global::FlounderSharp.GameObject _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.GameObject.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor((__Instance + __PointerAdjustment), __arg0);
            SetupVTables(GetType().FullName == "FlounderSharp.GameObject");
        }

        ~GameObject()
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
            global::FlounderSharp.GameObject __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            ((global::FlounderSharp.GameObject.__Internal*) __Instance)->vfptr_GameObject = new global::System.IntPtr(__OriginalVTables[0]);
            if (disposing)
            {
                var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 1 * 8);
                var ___dtorDelegate = (global::FlounderSharp.Delegates.Action_IntPtr_int) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Action_IntPtr_int));
                ___dtorDelegate((__Instance + __PointerAdjustment), 0);
            }
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public virtual void Update()
        {
            var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 2 * 8);
            var ___UpdateDelegate = (global::FlounderSharp.Delegates.Action_IntPtr) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Action_IntPtr));
            ___UpdateDelegate((__Instance + __PointerAdjustment));
        }

        public global::FlounderSharp.Component AddComponent(global::FlounderSharp.Component component)
        {
            var __arg0 = ReferenceEquals(component, null) ? global::System.IntPtr.Zero : component.__Instance;
            var __ret = __Internal.AddComponent((__Instance + __PointerAdjustment), __arg0);
            global::FlounderSharp.Component __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::FlounderSharp.Component.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::FlounderSharp.Component) global::FlounderSharp.Component.NativeToManagedMap[__ret];
            else global::FlounderSharp.Component.NativeToManagedMap[__ret] = __result0 = (global::FlounderSharp.Component) global::FlounderSharp.Component.__CreateInstance(__ret);
            return __result0;
        }

        public global::FlounderSharp.Component RemoveComponent(global::FlounderSharp.Component component)
        {
            var __arg0 = ReferenceEquals(component, null) ? global::System.IntPtr.Zero : component.__Instance;
            var __ret = __Internal.RemoveComponent((__Instance + __PointerAdjustment), __arg0);
            global::FlounderSharp.Component __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::FlounderSharp.Component.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::FlounderSharp.Component) global::FlounderSharp.Component.NativeToManagedMap[__ret];
            else global::FlounderSharp.Component.NativeToManagedMap[__ret] = __result0 = (global::FlounderSharp.Component) global::FlounderSharp.Component.__CreateInstance(__ret);
            return __result0;
        }

        public void StructureRemove()
        {
            __Internal.StructureRemove((__Instance + __PointerAdjustment));
        }

        protected string MName
        {
            get
            {
                var __basicStringRet = global::Std.BasicString<char, global::Std.CharTraits<char>, global::Std.Allocator<char>>.__CreateInstance(new global::System.IntPtr(&((global::FlounderSharp.GameObject.__Internal*) __Instance)->m_name));
                var __stringRet = global::Std.BasicStringExtensions.CStr(__basicStringRet);
                __basicStringRet.Dispose(false);
                return __stringRet;
            }

            set
            {
                var __allocator0 = new global::Std.Allocator<char>();
                var __basicString0 = global::Std.BasicStringExtensions.BasicString(value, __allocator0);
                ((global::FlounderSharp.GameObject.__Internal*)__Instance)->m_name = *(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C*) __basicString0.__Instance;
            }
        }

        protected global::FlounderSharp.Transform MTransform
        {
            get
            {
                global::FlounderSharp.Transform __result0;
                if (((global::FlounderSharp.GameObject.__Internal*) __Instance)->m_transform == IntPtr.Zero) __result0 = null;
                else if (global::FlounderSharp.Transform.NativeToManagedMap.ContainsKey(((global::FlounderSharp.GameObject.__Internal*) __Instance)->m_transform))
                    __result0 = (global::FlounderSharp.Transform) global::FlounderSharp.Transform.NativeToManagedMap[((global::FlounderSharp.GameObject.__Internal*) __Instance)->m_transform];
                else __result0 = global::FlounderSharp.Transform.__CreateInstance(((global::FlounderSharp.GameObject.__Internal*) __Instance)->m_transform);
                return __result0;
            }

            set
            {
                ((global::FlounderSharp.GameObject.__Internal*)__Instance)->m_transform = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            }
        }

        public string Name
        {
            get
            {
                var __ret = new global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C();
                __Internal.GetName((__Instance + __PointerAdjustment), new IntPtr(&__ret));
                var __basicStringRet = global::Std.BasicString<char, global::Std.CharTraits<char>, global::Std.Allocator<char>>.__CreateInstance(__ret);
                var __stringRet = global::Std.BasicStringExtensions.CStr(__basicStringRet);
                __basicStringRet.Dispose(false);
                return __stringRet;
            }

            set
            {
                var __allocator0 = new global::Std.Allocator<char>();
                var __basicString0 = global::Std.BasicStringExtensions.BasicString(value, __allocator0);
                var __arg0 = __basicString0.__Instance;
                __Internal.SetName((__Instance + __PointerAdjustment), __arg0);
                __basicString0.Dispose(false);
                __allocator0.Dispose();
            }
        }

        public global::FlounderSharp.Transform Transform
        {
            get
            {
                var __ret = __Internal.GetTransform((__Instance + __PointerAdjustment));
                global::FlounderSharp.Transform __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (global::FlounderSharp.Transform.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (global::FlounderSharp.Transform) global::FlounderSharp.Transform.NativeToManagedMap[__ret];
                else __result0 = global::FlounderSharp.Transform.__CreateInstance(__ret);
                return __result0;
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is a C++ reference (&).");
                var __arg0 = value.__Instance;
                __Internal.SetTransform((__Instance + __PointerAdjustment), __arg0);
            }
        }

        public bool Removed
        {
            get
            {
                var __ret = __Internal.GetRemoved((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        #region Virtual table interop

        // virtual ~GameObject()
        private static global::FlounderSharp.Delegates.Action_IntPtr_int _dtorDelegateInstance;

        private static void _dtorDelegateHook(global::System.IntPtr instance, int delete)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.GameObject) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.Dispose(true);
        }

        // void Update()
        private static global::FlounderSharp.Delegates.Action_IntPtr _UpdateDelegateInstance;

        private static void _UpdateDelegateHook(global::System.IntPtr instance)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.GameObject) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.Update();
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
                _UpdateDelegateInstance += _UpdateDelegateHook;
                _Thunks[1] = Marshal.GetFunctionPointerForDelegate(_UpdateDelegateInstance).ToPointer();
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