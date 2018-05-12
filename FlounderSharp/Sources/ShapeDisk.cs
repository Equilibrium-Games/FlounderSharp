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
    public unsafe partial class ShapeDisk : global::FlounderSharp.Model, IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 64)]
        public new partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr vfptr_IResource;

            [FieldOffset(8)]
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C m_filename;

            [FieldOffset(40)]
            internal global::System.IntPtr m_vertexBuffer;

            [FieldOffset(48)]
            internal global::System.IntPtr m_indexBuffer;

            [FieldOffset(56)]
            internal global::System.IntPtr m_aabb;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0ShapeDisk@fl@@QEAA@AEBM0AEBI1@Z")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr instance, float* innerRadius, float* outerRadius, uint* slices, uint* loops);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0ShapeDisk@fl@@QEAA@AEBV01@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?Resource@ShapeDisk@fl@@SAPEAV12@AEBM0AEBI1@Z")]
            internal static extern global::System.IntPtr Resource(float* innerRadius, float* outerRadius, uint* slices, uint* loops);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?Resource@ShapeDisk@fl@@SAPEAV12@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@Z")]
            internal static extern global::System.IntPtr Resource(global::System.IntPtr filename);
        }

        internal static new global::FlounderSharp.ShapeDisk __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::FlounderSharp.ShapeDisk(native.ToPointer(), skipVTables);
        }

        internal static global::FlounderSharp.ShapeDisk __CreateInstance(global::FlounderSharp.ShapeDisk.__Internal native, bool skipVTables = false)
        {
            return new global::FlounderSharp.ShapeDisk(native, skipVTables);
        }

        private static void* __CopyValue(global::FlounderSharp.ShapeDisk.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.ShapeDisk.__Internal));
            global::FlounderSharp.ShapeDisk.__Internal.cctor(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private ShapeDisk(global::FlounderSharp.ShapeDisk.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ShapeDisk(void* native, bool skipVTables = false)
            : base((void*) null)
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

        public ShapeDisk(ref float innerRadius, ref float outerRadius, ref uint slices, ref uint loops)
            : this((void*) null)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.ShapeDisk.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            fixed (float* __refParamPtr0 = &innerRadius)
            {
                var __arg0 = __refParamPtr0;
                fixed (float* __refParamPtr1 = &outerRadius)
                {
                    var __arg1 = __refParamPtr1;
                    fixed (uint* __refParamPtr2 = &slices)
                    {
                        var __arg2 = __refParamPtr2;
                        fixed (uint* __refParamPtr3 = &loops)
                        {
                            var __arg3 = __refParamPtr3;
                            __Internal.ctor((__Instance + __PointerAdjustment), __arg0, __arg1, __arg2, __arg3);
                        }
                    }
                }
            }
            SetupVTables(GetType().FullName == "FlounderSharp.ShapeDisk");
        }

        public ShapeDisk(global::FlounderSharp.ShapeDisk _0)
            : this((void*) null)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.ShapeDisk.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor((__Instance + __PointerAdjustment), __arg0);
            SetupVTables(GetType().FullName == "FlounderSharp.ShapeDisk");
        }

        ~ShapeDisk()
        {
            Dispose(false);
        }

        public static global::FlounderSharp.ShapeDisk Resource(ref float innerRadius, ref float outerRadius, ref uint slices, ref uint loops)
        {
            fixed (float* __refParamPtr0 = &innerRadius)
            {
                var __arg0 = __refParamPtr0;
                fixed (float* __refParamPtr1 = &outerRadius)
                {
                    var __arg1 = __refParamPtr1;
                    fixed (uint* __refParamPtr2 = &slices)
                    {
                        var __arg2 = __refParamPtr2;
                        fixed (uint* __refParamPtr3 = &loops)
                        {
                            var __arg3 = __refParamPtr3;
                            var __ret = __Internal.Resource(__arg0, __arg1, __arg2, __arg3);
                            global::FlounderSharp.ShapeDisk __result0;
                            if (__ret == IntPtr.Zero) __result0 = null;
                            else if (global::FlounderSharp.ShapeDisk.NativeToManagedMap.ContainsKey(__ret))
                                __result0 = (global::FlounderSharp.ShapeDisk) global::FlounderSharp.ShapeDisk.NativeToManagedMap[__ret];
                            else global::FlounderSharp.ShapeDisk.NativeToManagedMap[__ret] = __result0 = (global::FlounderSharp.ShapeDisk) global::FlounderSharp.ShapeDisk.__CreateInstance(__ret);
                            return __result0;
                        }
                    }
                }
            }
        }

        public static global::FlounderSharp.ShapeDisk Resource(string filename)
        {
            var __allocator0 = new global::Std.Allocator<char>();
            var __basicString0 = global::Std.BasicStringExtensions.BasicString(filename, __allocator0);
            var __arg0 = __basicString0.__Instance;
            var __ret = __Internal.Resource(__arg0);
            __basicString0.Dispose(false);
            __allocator0.Dispose();
            global::FlounderSharp.ShapeDisk __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::FlounderSharp.ShapeDisk.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::FlounderSharp.ShapeDisk) global::FlounderSharp.ShapeDisk.NativeToManagedMap[__ret];
            else global::FlounderSharp.ShapeDisk.NativeToManagedMap[__ret] = __result0 = (global::FlounderSharp.ShapeDisk) global::FlounderSharp.ShapeDisk.__CreateInstance(__ret);
            return __result0;
        }

        #region Virtual table interop

        // ~ShapeDisk()
        private static global::FlounderSharp.Delegates.Action_IntPtr_int _dtorDelegateInstance;

        private static void _dtorDelegateHook(global::System.IntPtr instance, int delete)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.ShapeDisk) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.Dispose(true);
        }

        // std::string GetFilename() override { return m_filename; }
        private static global::FlounderSharp.Delegates.Action_IntPtr_IntPtr _GetFilenameDelegateInstance;

        private static void _GetFilenameDelegateHook(global::System.IntPtr instance, global::System.IntPtr @return)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.ShapeDisk) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            var __ret = __target.Filename;
            var __allocator0 = new global::Std.Allocator<char>();
            var __basicString0 = global::Std.BasicStringExtensions.BasicString(__ret, __allocator0);
            *(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C*) @return = *(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C*) __basicString0.__Instance;
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
                _GetFilenameDelegateInstance += _GetFilenameDelegateHook;
                _Thunks[1] = Marshal.GetFunctionPointerForDelegate(_GetFilenameDelegateInstance).ToPointer();
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