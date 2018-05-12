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
    /// <summary>A class that holds many various math functions.</summary>
    public unsafe partial class Maths : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?LogRandom@Maths@fl@@SANAEBN0@Z")]
            internal static extern double LogRandom(double* lowerLimit, double* upperLimit);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?NormallyDistributedSingle@Maths@fl@@SAMAEBM0@Z")]
            internal static extern float NormallyDistributedSingle(float* standardDeviation, float* mean);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?Random@Maths@fl@@SAMXZ")]
            internal static extern float Random();
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::FlounderSharp.Maths> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::FlounderSharp.Maths>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::FlounderSharp.Maths __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::FlounderSharp.Maths(native.ToPointer(), skipVTables);
        }

        internal static global::FlounderSharp.Maths __CreateInstance(global::FlounderSharp.Maths.__Internal native, bool skipVTables = false)
        {
            return new global::FlounderSharp.Maths(native, skipVTables);
        }

        private static void* __CopyValue(global::FlounderSharp.Maths.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.Maths.__Internal));
            *(global::FlounderSharp.Maths.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Maths(global::FlounderSharp.Maths.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Maths(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        ~Maths()
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
            global::FlounderSharp.Maths __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>Creates a number between two numbers, logarithmic.</summary>
        /// <param name="lowerLimit">The lower number.</param>
        /// <param name="upperLimit">The upper number.</param>
        public static double LogRandom(ref double lowerLimit, ref double upperLimit)
        {
            fixed (double* __refParamPtr0 = &lowerLimit)
            {
                var __arg0 = __refParamPtr0;
                fixed (double* __refParamPtr1 = &upperLimit)
                {
                    var __arg1 = __refParamPtr1;
                    var __ret = __Internal.LogRandom(__arg0, __arg1);
                    return __ret;
                }
            }
        }

        /// <summary>Generates a single value from a normal distribution, using Box-Muller. https://en.wikipedia.org/wiki/Box%E2%80%93Muller_transform</summary>
        /// <param name="standardDeviation">The standards deviation of the distribution.</param>
        /// <param name="mean">The mean of the distribution.</param>
        public static float NormallyDistributedSingle(ref float standardDeviation, ref float mean)
        {
            fixed (float* __refParamPtr0 = &standardDeviation)
            {
                var __arg0 = __refParamPtr0;
                fixed (float* __refParamPtr1 = &mean)
                {
                    var __arg1 = __refParamPtr1;
                    var __ret = __Internal.NormallyDistributedSingle(__arg0, __arg1);
                    return __ret;
                }
            }
        }

        /// <summary>Gets a random number.</summary>
        public static float Random
        {
            get
            {
                var __ret = __Internal.Random();
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