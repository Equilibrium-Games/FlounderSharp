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
    /// <summary>A instance of a particle type.</summary>
    public unsafe partial class Particle : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 80)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr m_particleType;

            [FieldOffset(8)]
            internal global::System.IntPtr m_position;

            [FieldOffset(16)]
            internal global::System.IntPtr m_velocity;

            [FieldOffset(24)]
            internal global::System.IntPtr m_change;

            [FieldOffset(32)]
            internal global::System.IntPtr m_textureOffset1;

            [FieldOffset(40)]
            internal global::System.IntPtr m_textureOffset2;

            [FieldOffset(48)]
            internal float m_lifeLength;

            [FieldOffset(52)]
            internal float m_rotation;

            [FieldOffset(56)]
            internal float m_scale;

            [FieldOffset(60)]
            internal float m_gravityEffect;

            [FieldOffset(64)]
            internal float m_elapsedTime;

            [FieldOffset(68)]
            internal float m_transparency;

            [FieldOffset(72)]
            internal float m_textureBlendFactor;

            [FieldOffset(76)]
            internal float m_distanceToCamera;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0Particle@fl@@QEAA@PEAVParticleType@1@AEBVVector3@1@1AEBM222@Z")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr instance, global::System.IntPtr particleType, global::System.IntPtr position, global::System.IntPtr velocity, float* lifeLength, float* rotation, float* scale, float* gravityEffect);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??1Particle@fl@@QEAA@XZ")]
            internal static extern void dtor(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?Update@Particle@fl@@QEAAXXZ")]
            internal static extern void Update(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??MParticle@fl@@QEBA_NAEBV01@@Z")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool OperatorLess(global::System.IntPtr instance, global::System.IntPtr other);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?IsAlive@Particle@fl@@QEBA_NXZ")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool IsAlive(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetParticleType@Particle@fl@@QEBAPEAVParticleType@2@XZ")]
            internal static extern global::System.IntPtr GetParticleType(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetPosition@Particle@fl@@QEBAPEAVVector3@2@XZ")]
            internal static extern global::System.IntPtr GetPosition(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetVelocity@Particle@fl@@QEBAPEAVVector3@2@XZ")]
            internal static extern global::System.IntPtr GetVelocity(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetChange@Particle@fl@@QEBAPEAVVector3@2@XZ")]
            internal static extern global::System.IntPtr GetChange(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetTextureOffset1@Particle@fl@@QEBAPEAVVector2@2@XZ")]
            internal static extern global::System.IntPtr GetTextureOffset1(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetTextureOffset2@Particle@fl@@QEBAPEAVVector2@2@XZ")]
            internal static extern global::System.IntPtr GetTextureOffset2(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetLifeLength@Particle@fl@@QEBAMXZ")]
            internal static extern float GetLifeLength(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetRotation@Particle@fl@@QEBAMXZ")]
            internal static extern float GetRotation(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetScale@Particle@fl@@QEBAMXZ")]
            internal static extern float GetScale(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetGravityEffect@Particle@fl@@QEBAMXZ")]
            internal static extern float GetGravityEffect(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetElapsedTime@Particle@fl@@QEBAMXZ")]
            internal static extern float GetElapsedTime(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetTransparency@Particle@fl@@QEBAMXZ")]
            internal static extern float GetTransparency(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetTextureBlendFactor@Particle@fl@@QEBAMXZ")]
            internal static extern float GetTextureBlendFactor(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?DistanceToCamera@Particle@fl@@QEBAMXZ")]
            internal static extern float DistanceToCamera(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::FlounderSharp.Particle> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::FlounderSharp.Particle>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::FlounderSharp.Particle __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::FlounderSharp.Particle(native.ToPointer(), skipVTables);
        }

        internal static global::FlounderSharp.Particle __CreateInstance(global::FlounderSharp.Particle.__Internal native, bool skipVTables = false)
        {
            return new global::FlounderSharp.Particle(native, skipVTables);
        }

        private static void* __CopyValue(global::FlounderSharp.Particle.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.Particle.__Internal));
            *(global::FlounderSharp.Particle.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Particle(global::FlounderSharp.Particle.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Particle(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        /// <summary>Creates a new particle object.</summary>
        /// <param name="particleType">The particle template to build from.</param>
        /// <param name="position">The particles initial position.</param>
        /// <param name="velocity">The particles initial velocity.</param>
        /// <param name="lifeLength">The particles life length.</param>
        /// <param name="rotation">The particles rotation.</param>
        /// <param name="scale">The particles scale.</param>
        /// <param name="gravityEffect">The particles gravity effect.</param>
        public Particle(global::FlounderSharp.ParticleType particleType, global::FlounderSharp.Vector3 position, global::FlounderSharp.Vector3 velocity, ref float lifeLength, ref float rotation, ref float scale, ref float gravityEffect)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.Particle.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var __arg0 = ReferenceEquals(particleType, null) ? global::System.IntPtr.Zero : particleType.__Instance;
            if (ReferenceEquals(position, null))
                throw new global::System.ArgumentNullException("position", "Cannot be null because it is a C++ reference (&).");
            var __arg1 = position.__Instance;
            if (ReferenceEquals(velocity, null))
                throw new global::System.ArgumentNullException("velocity", "Cannot be null because it is a C++ reference (&).");
            var __arg2 = velocity.__Instance;
            fixed (float* __refParamPtr3 = &lifeLength)
            {
                var __arg3 = __refParamPtr3;
                fixed (float* __refParamPtr4 = &rotation)
                {
                    var __arg4 = __refParamPtr4;
                    fixed (float* __refParamPtr5 = &scale)
                    {
                        var __arg5 = __refParamPtr5;
                        fixed (float* __refParamPtr6 = &gravityEffect)
                        {
                            var __arg6 = __refParamPtr6;
                            __Internal.ctor((__Instance + __PointerAdjustment), __arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                        }
                    }
                }
            }
        }

        ~Particle()
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
            global::FlounderSharp.Particle __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                __Internal.dtor((__Instance + __PointerAdjustment), 0);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>Updates the particle.</summary>
        public void Update()
        {
            __Internal.Update((__Instance + __PointerAdjustment));
        }

        public static bool operator >(global::FlounderSharp.Particle __op, global::FlounderSharp.Particle other)
        {
            return !(__op < other);
        }

        public static bool operator <(global::FlounderSharp.Particle __op, global::FlounderSharp.Particle other)
        {
            if (ReferenceEquals(__op, null))
                throw new global::System.ArgumentNullException("__op", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = __op.__Instance;
            if (ReferenceEquals(other, null))
                throw new global::System.ArgumentNullException("other", "Cannot be null because it is a C++ reference (&).");
            var __arg1 = other.__Instance;
            var __ret = __Internal.OperatorLess(__arg0, __arg1);
            return __ret;
        }

        public bool IsAlive
        {
            get
            {
                var __ret = __Internal.IsAlive((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public global::FlounderSharp.ParticleType ParticleType
        {
            get
            {
                var __ret = __Internal.GetParticleType((__Instance + __PointerAdjustment));
                global::FlounderSharp.ParticleType __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (global::FlounderSharp.ParticleType.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (global::FlounderSharp.ParticleType) global::FlounderSharp.ParticleType.NativeToManagedMap[__ret];
                else __result0 = global::FlounderSharp.ParticleType.__CreateInstance(__ret);
                return __result0;
            }
        }

        public global::FlounderSharp.Vector3 Position
        {
            get
            {
                var __ret = __Internal.GetPosition((__Instance + __PointerAdjustment));
                global::FlounderSharp.Vector3 __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (global::FlounderSharp.Vector3.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (global::FlounderSharp.Vector3) global::FlounderSharp.Vector3.NativeToManagedMap[__ret];
                else __result0 = global::FlounderSharp.Vector3.__CreateInstance(__ret);
                return __result0;
            }
        }

        public global::FlounderSharp.Vector3 Velocity
        {
            get
            {
                var __ret = __Internal.GetVelocity((__Instance + __PointerAdjustment));
                global::FlounderSharp.Vector3 __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (global::FlounderSharp.Vector3.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (global::FlounderSharp.Vector3) global::FlounderSharp.Vector3.NativeToManagedMap[__ret];
                else __result0 = global::FlounderSharp.Vector3.__CreateInstance(__ret);
                return __result0;
            }
        }

        public global::FlounderSharp.Vector3 Change
        {
            get
            {
                var __ret = __Internal.GetChange((__Instance + __PointerAdjustment));
                global::FlounderSharp.Vector3 __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (global::FlounderSharp.Vector3.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (global::FlounderSharp.Vector3) global::FlounderSharp.Vector3.NativeToManagedMap[__ret];
                else __result0 = global::FlounderSharp.Vector3.__CreateInstance(__ret);
                return __result0;
            }
        }

        public global::FlounderSharp.Vector2 TextureOffset1
        {
            get
            {
                var __ret = __Internal.GetTextureOffset1((__Instance + __PointerAdjustment));
                global::FlounderSharp.Vector2 __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (global::FlounderSharp.Vector2.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (global::FlounderSharp.Vector2) global::FlounderSharp.Vector2.NativeToManagedMap[__ret];
                else __result0 = global::FlounderSharp.Vector2.__CreateInstance(__ret);
                return __result0;
            }
        }

        public global::FlounderSharp.Vector2 TextureOffset2
        {
            get
            {
                var __ret = __Internal.GetTextureOffset2((__Instance + __PointerAdjustment));
                global::FlounderSharp.Vector2 __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (global::FlounderSharp.Vector2.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (global::FlounderSharp.Vector2) global::FlounderSharp.Vector2.NativeToManagedMap[__ret];
                else __result0 = global::FlounderSharp.Vector2.__CreateInstance(__ret);
                return __result0;
            }
        }

        public float LifeLength
        {
            get
            {
                var __ret = __Internal.GetLifeLength((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public float Rotation
        {
            get
            {
                var __ret = __Internal.GetRotation((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public float Scale
        {
            get
            {
                var __ret = __Internal.GetScale((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public float GravityEffect
        {
            get
            {
                var __ret = __Internal.GetGravityEffect((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public float ElapsedTime
        {
            get
            {
                var __ret = __Internal.GetElapsedTime((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public float Transparency
        {
            get
            {
                var __ret = __Internal.GetTransparency((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public float TextureBlendFactor
        {
            get
            {
                var __ret = __Internal.GetTextureBlendFactor((__Instance + __PointerAdjustment));
                return __ret;
            }
        }

        public float DistanceToCamera
        {
            get
            {
                var __ret = __Internal.DistanceToCamera((__Instance + __PointerAdjustment));
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