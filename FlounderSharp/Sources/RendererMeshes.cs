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
    public unsafe partial class RendererMeshes : global::FlounderSharp.IRenderer, IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public new partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr vfptr_IRenderer;

            [FieldOffset(8)]
            internal global::System.IntPtr m_uniformScene;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0RendererMeshes@fl@@QEAA@AEBVGraphicsStage@1@@Z")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr instance, global::System.IntPtr graphicsStage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0RendererMeshes@fl@@QEAA@AEBV01@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        internal static new global::FlounderSharp.RendererMeshes __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::FlounderSharp.RendererMeshes(native.ToPointer(), skipVTables);
        }

        internal static global::FlounderSharp.RendererMeshes __CreateInstance(global::FlounderSharp.RendererMeshes.__Internal native, bool skipVTables = false)
        {
            return new global::FlounderSharp.RendererMeshes(native, skipVTables);
        }

        private static void* __CopyValue(global::FlounderSharp.RendererMeshes.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.RendererMeshes.__Internal));
            global::FlounderSharp.RendererMeshes.__Internal.cctor_1(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private RendererMeshes(global::FlounderSharp.RendererMeshes.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected RendererMeshes(void* native, bool skipVTables = false)
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

        public RendererMeshes(global::FlounderSharp.GraphicsStage graphicsStage)
            : this((void*) null)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.RendererMeshes.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(graphicsStage, null))
                throw new global::System.ArgumentNullException("graphicsStage", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = graphicsStage.__Instance;
            __Internal.ctor((__Instance + __PointerAdjustment), __arg0);
            SetupVTables(GetType().FullName == "FlounderSharp.RendererMeshes");
        }

        public RendererMeshes(global::FlounderSharp.RendererMeshes _0)
            : this((void*) null)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.RendererMeshes.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor_1((__Instance + __PointerAdjustment), __arg0);
            SetupVTables(GetType().FullName == "FlounderSharp.RendererMeshes");
        }

        ~RendererMeshes()
        {
            Dispose(false);
        }

        public override void Render(global::VkCommandBufferT commandBuffer, global::FlounderSharp.Vector4 clipPlane, global::FlounderSharp.ICamera camera)
        {
            var __slot = *(void**) ((IntPtr) __OriginalVTables[0] + 2 * 8);
            var ___RenderDelegate = (global::FlounderSharp.Delegates.Action_IntPtr_IntPtr_IntPtr_IntPtr) Marshal.GetDelegateForFunctionPointer(new IntPtr(__slot), typeof(global::FlounderSharp.Delegates.Action_IntPtr_IntPtr_IntPtr_IntPtr));
            if (ReferenceEquals(commandBuffer, null))
                throw new global::System.ArgumentNullException("commandBuffer", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = commandBuffer.__Instance;
            if (ReferenceEquals(clipPlane, null))
                throw new global::System.ArgumentNullException("clipPlane", "Cannot be null because it is a C++ reference (&).");
            var __arg1 = clipPlane.__Instance;
            if (ReferenceEquals(camera, null))
                throw new global::System.ArgumentNullException("camera", "Cannot be null because it is a C++ reference (&).");
            var __arg2 = camera.__Instance;
            ___RenderDelegate((__Instance + __PointerAdjustment), __arg0, __arg1, __arg2);
        }

        public static implicit operator global::FlounderSharp.RendererMeshes(global::FlounderSharp.GraphicsStage graphicsStage)
        {
            return new global::FlounderSharp.RendererMeshes(graphicsStage);
        }

        #region Virtual table interop

        // ~RendererMeshes()
        private static global::FlounderSharp.Delegates.Action_IntPtr_int _dtorDelegateInstance;

        private static void _dtorDelegateHook(global::System.IntPtr instance, int delete)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.RendererMeshes) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            __target.Dispose(true);
        }

        // void Render(const VkCommandBuffer &commandBuffer, const Vector4 &clipPlane, const ICamera &camera) override
        private static global::FlounderSharp.Delegates.Action_IntPtr_IntPtr_IntPtr_IntPtr _RenderDelegateInstance;

        private static void _RenderDelegateHook(global::System.IntPtr instance, global::System.IntPtr commandBuffer, global::System.IntPtr clipPlane, global::System.IntPtr camera)
        {
            if (!NativeToManagedMap.ContainsKey(instance))
                throw new global::System.Exception("No managed instance was found");

            var __target = (global::FlounderSharp.RendererMeshes) NativeToManagedMap[instance];
            if (__target.__ownsNativeInstance)
                __target.SetupVTables();
            global::VkCommandBufferT __result0;
            if (commandBuffer == IntPtr.Zero) __result0 = null;
            else if (global::VkCommandBufferT.NativeToManagedMap.ContainsKey(commandBuffer))
                __result0 = (global::VkCommandBufferT) global::VkCommandBufferT.NativeToManagedMap[commandBuffer];
            else __result0 = global::VkCommandBufferT.__CreateInstance(commandBuffer);
            global::FlounderSharp.Vector4 __result1;
            if (clipPlane == IntPtr.Zero) __result1 = null;
            else if (global::FlounderSharp.Vector4.NativeToManagedMap.ContainsKey(clipPlane))
                __result1 = (global::FlounderSharp.Vector4) global::FlounderSharp.Vector4.NativeToManagedMap[clipPlane];
            else __result1 = global::FlounderSharp.Vector4.__CreateInstance(clipPlane);
            global::FlounderSharp.ICamera __result2;
            if (camera == IntPtr.Zero) __result2 = null;
            else if (global::FlounderSharp.ICamera.NativeToManagedMap.ContainsKey(camera))
                __result2 = (global::FlounderSharp.ICamera) global::FlounderSharp.ICamera.NativeToManagedMap[camera];
            else __result2 = (global::FlounderSharp.ICamera) global::FlounderSharp.ICamera.__CreateInstance(camera, skipVTables: true);
            __target.Render(__result0, __result1, __result2);
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