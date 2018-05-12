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
    public enum ChunkMesh
    {
        MeshGreedy = 0,
        MeshSimple = 1
    }

    public unsafe partial class VoxelChunk : global::FlounderSharp.Component, IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 72)]
        public new partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr vfptr_Component;

            [FieldOffset(8)]
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C m_name;

            [FieldOffset(40)]
            internal global::System.IntPtr m_gameObject;

            [FieldOffset(48)]
            internal byte m_enabled;

            [FieldOffset(56)]
            internal global::System.IntPtr m_blocks;

            [FieldOffset(64)]
            internal global::FlounderSharp.ChunkMesh m_chunkMesh;

            [FieldOffset(68)]
            internal byte m_generate;

            [FieldOffset(69)]
            internal byte m_rebuild;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0VoxelChunk@fl@@QEAA@AEBW4ChunkMesh@1@AEB_N@Z")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr instance, global::FlounderSharp.ChunkMesh* chunkMesh, bool* generate);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0VoxelChunk@fl@@QEAA@AEBV01@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetBlock@VoxelChunk@fl@@QEAAPEAVVoxelBlock@2@AEBH00@Z")]
            internal static extern global::System.IntPtr GetBlock(global::System.IntPtr instance, int* x, int* y, int* z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?IsBlockFilled@VoxelChunk@fl@@QEAA_NAEBH00@Z")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool IsBlockFilled(global::System.IntPtr instance, int* x, int* y, int* z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?IsFaceVisible@VoxelChunk@fl@@QEAA_NAEBH00AEBW4BlockFace@2@@Z")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool IsFaceVisible(global::System.IntPtr instance, int* x, int* y, int* z, global::FlounderSharp.BlockFace* faceType);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?Rebuild@VoxelChunk@fl@@QEAAXXZ")]
            internal static extern void Rebuild(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?SetName@Component@fl@@QEAAXAEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@Z")]
            internal static extern void SetName(global::System.IntPtr instance, global::System.IntPtr name);
        }

        internal static new global::FlounderSharp.VoxelChunk __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::FlounderSharp.VoxelChunk(native.ToPointer(), skipVTables);
        }

        internal static global::FlounderSharp.VoxelChunk __CreateInstance(global::FlounderSharp.VoxelChunk.__Internal native, bool skipVTables = false)
        {
            return new global::FlounderSharp.VoxelChunk(native, skipVTables);
        }

        private static void* __CopyValue(global::FlounderSharp.VoxelChunk.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.VoxelChunk.__Internal));
            global::FlounderSharp.VoxelChunk.__Internal.cctor(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private VoxelChunk(global::FlounderSharp.VoxelChunk.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected VoxelChunk(void* native, bool skipVTables = false)
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

        public VoxelChunk(global::FlounderSharp.ChunkMesh* chunkMesh, ref bool generate)
            : this((void*) null)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.VoxelChunk.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            fixed (bool* __refParamPtr1 = &generate)
            {
                var __arg1 = __refParamPtr1;
                __Internal.ctor((__Instance + __PointerAdjustment), chunkMesh, __arg1);
            }
            SetupVTables(GetType().FullName == "FlounderSharp.VoxelChunk");
        }

        public VoxelChunk(global::FlounderSharp.VoxelChunk _0)
            : this((void*) null)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.VoxelChunk.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor((__Instance + __PointerAdjustment), __arg0);
            SetupVTables(GetType().FullName == "FlounderSharp.VoxelChunk");
        }

        ~VoxelChunk()
        {
            Dispose(false);
        }

        public override void Update()
        {
            var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 2 * 8);
            var ___UpdateDelegate = (global::FlounderSharp.Delegates.Action_IntPtr) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Action_IntPtr));
            ___UpdateDelegate((__Instance + __PointerAdjustment));
        }

        public override void Load(global::FlounderSharp.LoadedValue value)
        {
            var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 3 * 8);
            var ___LoadDelegate = (global::FlounderSharp.Delegates.Action_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Action_IntPtr_IntPtr));
            var __arg0 = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            ___LoadDelegate((__Instance + __PointerAdjustment), __arg0);
        }

        public override void Write(global::FlounderSharp.LoadedValue value)
        {
            var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 4 * 8);
            var ___WriteDelegate = (global::FlounderSharp.Delegates.Action_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Action_IntPtr_IntPtr));
            var __arg0 = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            ___WriteDelegate((__Instance + __PointerAdjustment), __arg0);
        }

        public global::FlounderSharp.VoxelBlock GetBlock(ref int x, ref int y, ref int z)
        {
            fixed (int* __refParamPtr0 = &x)
            {
                var __arg0 = __refParamPtr0;
                fixed (int* __refParamPtr1 = &y)
                {
                    var __arg1 = __refParamPtr1;
                    fixed (int* __refParamPtr2 = &z)
                    {
                        var __arg2 = __refParamPtr2;
                        var __ret = __Internal.GetBlock((__Instance + __PointerAdjustment), __arg0, __arg1, __arg2);
                        global::FlounderSharp.VoxelBlock __result0;
                        if (__ret == IntPtr.Zero) __result0 = null;
                        else if (global::FlounderSharp.VoxelBlock.NativeToManagedMap.ContainsKey(__ret))
                            __result0 = (global::FlounderSharp.VoxelBlock) global::FlounderSharp.VoxelBlock.NativeToManagedMap[__ret];
                        else __result0 = global::FlounderSharp.VoxelBlock.__CreateInstance(__ret);
                        return __result0;
                    }
                }
            }
        }

        public bool IsBlockFilled(ref int x, ref int y, ref int z)
        {
            fixed (int* __refParamPtr0 = &x)
            {
                var __arg0 = __refParamPtr0;
                fixed (int* __refParamPtr1 = &y)
                {
                    var __arg1 = __refParamPtr1;
                    fixed (int* __refParamPtr2 = &z)
                    {
                        var __arg2 = __refParamPtr2;
                        var __ret = __Internal.IsBlockFilled((__Instance + __PointerAdjustment), __arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public bool IsFaceVisible(ref int x, ref int y, ref int z, global::FlounderSharp.BlockFace* faceType)
        {
            fixed (int* __refParamPtr0 = &x)
            {
                var __arg0 = __refParamPtr0;
                fixed (int* __refParamPtr1 = &y)
                {
                    var __arg1 = __refParamPtr1;
                    fixed (int* __refParamPtr2 = &z)
                    {
                        var __arg2 = __refParamPtr2;
                        var __ret = __Internal.IsFaceVisible((__Instance + __PointerAdjustment), __arg0, __arg1, __arg2, faceType);
                        return __ret;
                    }
                }
            }
        }

        public void Rebuild()
        {
            __Internal.Rebuild((__Instance + __PointerAdjustment));
        }

        public static int CHUNK_WIDTH
        {
            get
            {
                var __ptr = (int*)CppSharp.SymbolResolver.ResolveSymbol("Flounder", "_imp_?CHUNK_WIDTH@VoxelChunk@fl@@2HB");
                return *__ptr;
            }
        }

        public static int CHUNK_HEIGHT
        {
            get
            {
                var __ptr = (int*)CppSharp.SymbolResolver.ResolveSymbol("Flounder", "_imp_?CHUNK_HEIGHT@VoxelChunk@fl@@2HB");
                return *__ptr;
            }
        }

        public static float VOXEL_SIZE
        {
            get
            {
                var __ptr = (float*)CppSharp.SymbolResolver.ResolveSymbol("Flounder", "_imp_?VOXEL_SIZE@VoxelChunk@fl@@2MB");
                return *__ptr;
            }
        }

        public static global::FlounderSharp.Vector3 CHUNK_SIZE
        {
            get
            {
                var __ptr = (global::System.IntPtr*)CppSharp.SymbolResolver.ResolveSymbol("Flounder", "_imp_?CHUNK_SIZE@VoxelChunk@fl@@2PEBVVector3@2@EB");
                global::FlounderSharp.Vector3 __result0;
                if (*__ptr == IntPtr.Zero) __result0 = null;
                else if (global::FlounderSharp.Vector3.NativeToManagedMap.ContainsKey(*__ptr))
                    __result0 = (global::FlounderSharp.Vector3) global::FlounderSharp.Vector3.NativeToManagedMap[*__ptr];
                else __result0 = global::FlounderSharp.Vector3.__CreateInstance(*__ptr);
                return __result0;
            }

            set
            {
                var __ptr = (global::System.IntPtr*)CppSharp.SymbolResolver.ResolveSymbol("Flounder", "_imp_?CHUNK_SIZE@VoxelChunk@fl@@2PEBVVector3@2@EB");
                *__ptr = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            }
        }

        public override string Name
        {
            get
            {
                var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 5 * 8);
                var ___GetNameDelegate = (global::FlounderSharp.Delegates.Action_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Action_IntPtr_IntPtr));
                var __ret = new global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C();
                ___GetNameDelegate((__Instance + __PointerAdjustment), new IntPtr(&__ret));
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

        #region Virtual table interop

        // ~VoxelChunk()
        private static global::FlounderSharp.Delegates.Action_IntPtr_int _dtorDelegateInstance;

        private static void _dtorDelegateHook(global::System.IntPtr instance, int delete)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.VoxelChunk) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.Dispose(true);
        }

        // void Update() override
        private static global::FlounderSharp.Delegates.Action_IntPtr _UpdateDelegateInstance;

        private static void _UpdateDelegateHook(global::System.IntPtr instance)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.VoxelChunk) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.Update();
        }

        // void Load(LoadedValue *value) override
        private static global::FlounderSharp.Delegates.Action_IntPtr_IntPtr _LoadDelegateInstance;

        private static void _LoadDelegateHook(global::System.IntPtr instance, global::System.IntPtr value)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.VoxelChunk) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::FlounderSharp.LoadedValue __result0;
            if (value == IntPtr.Zero) __result0 = null;
            else if (global::FlounderSharp.LoadedValue.NativeToManagedMap.ContainsKey(value))
                __result0 = (global::FlounderSharp.LoadedValue) global::FlounderSharp.LoadedValue.NativeToManagedMap[value];
            else __result0 = global::FlounderSharp.LoadedValue.__CreateInstance(value);
            __target.Load(__result0);
        }

        // void Write(LoadedValue *value) override
        private static global::FlounderSharp.Delegates.Action_IntPtr_IntPtr _WriteDelegateInstance;

        private static void _WriteDelegateHook(global::System.IntPtr instance, global::System.IntPtr value)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.VoxelChunk) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::FlounderSharp.LoadedValue __result0;
            if (value == IntPtr.Zero) __result0 = null;
            else if (global::FlounderSharp.LoadedValue.NativeToManagedMap.ContainsKey(value))
                __result0 = (global::FlounderSharp.LoadedValue) global::FlounderSharp.LoadedValue.NativeToManagedMap[value];
            else __result0 = global::FlounderSharp.LoadedValue.__CreateInstance(value);
            __target.Write(__result0);
        }

        // std::string GetName() const override { return "Chunk"; }
        private static global::FlounderSharp.Delegates.Action_IntPtr_IntPtr _GetNameDelegateInstance;

        private static void _GetNameDelegateHook(global::System.IntPtr instance, global::System.IntPtr @return)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.VoxelChunk) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            var __ret = __target.Name;
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
                _Thunks = new void*[5];
                _dtorDelegateInstance += _dtorDelegateHook;
                _Thunks[0] = Marshal.GetFunctionPointerForDelegate(_dtorDelegateInstance).ToPointer();
                _UpdateDelegateInstance += _UpdateDelegateHook;
                _Thunks[1] = Marshal.GetFunctionPointerForDelegate(_UpdateDelegateInstance).ToPointer();
                _LoadDelegateInstance += _LoadDelegateHook;
                _Thunks[2] = Marshal.GetFunctionPointerForDelegate(_LoadDelegateInstance).ToPointer();
                _WriteDelegateInstance += _WriteDelegateHook;
                _Thunks[3] = Marshal.GetFunctionPointerForDelegate(_WriteDelegateInstance).ToPointer();
                _GetNameDelegateInstance += _GetNameDelegateHook;
                _Thunks[4] = Marshal.GetFunctionPointerForDelegate(_GetNameDelegateInstance).ToPointer();
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
                    *(void**) (vfptr0 + 40) = _Thunks[4];
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