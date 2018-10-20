// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace AcidSharp
{
    /// <summary>A class that holds many various math functions.</summary>
    public unsafe partial class Maths : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("Acid", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0Maths@acid@@QEAA@AEBV01@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Acid", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?Random@Maths@acid@@SAMAEBM0@Z")]
            internal static extern float Random(float* min, float* max);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Acid", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?RandomNormal@Maths@acid@@SAMAEBM0@Z")]
            internal static extern float RandomNormal(float* standardDeviation, float* mean);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Acid", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?RandomLog@Maths@acid@@SAMAEBM0@Z")]
            internal static extern float RandomLog(float* min, float* max);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Acid", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?Radians@Maths@acid@@SAMAEBM@Z")]
            internal static extern float Radians(float* degrees);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Acid", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?Degrees@Maths@acid@@SAMAEBM@Z")]
            internal static extern float Degrees(float* radians);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Acid", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?WrapDegrees@Maths@acid@@SAMAEBM@Z")]
            internal static extern float WrapDegrees(float* degrees);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Acid", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?WrapRadians@Maths@acid@@SAMAEBM@Z")]
            internal static extern float WrapRadians(float* radians);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Acid", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?RoundToPlace@Maths@acid@@SAMAEBMAEBH@Z")]
            internal static extern float RoundToPlace(float* value, int* place);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Acid", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?Deadband@Maths@acid@@SAMAEBM0@Z")]
            internal static extern float Deadband(float* min, float* value);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Acid", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?AlmostEqual@Maths@acid@@SA_NAEBM00@Z")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool AlmostEqual(float* a, float* b, float* eps);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Acid", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?SmoothDamp@Maths@acid@@SAMAEBM00@Z")]
            internal static extern float SmoothDamp(float* current, float* target, float* rate);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Acid", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?Lerp@Maths@acid@@SAMAEBM00@Z")]
            internal static extern float Lerp(float* a, float* b, float* factor);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Acid", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?Interpolate@Maths@acid@@SAMAEBM00@Z")]
            internal static extern float Interpolate(float* a, float* b, float* blend);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Acid", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?InterpolateCosine@Maths@acid@@SAMAEBM00@Z")]
            internal static extern float InterpolateCosine(float* a, float* b, float* blend);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Acid", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?SmoothlyStep@Maths@acid@@SAMAEBM00@Z")]
            internal static extern float SmoothlyStep(float* edge0, float* edge1, float* x);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AcidSharp.Maths> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AcidSharp.Maths>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::AcidSharp.Maths __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AcidSharp.Maths(native.ToPointer(), skipVTables);
        }

        internal static global::AcidSharp.Maths __CreateInstance(global::AcidSharp.Maths.__Internal native, bool skipVTables = false)
        {
            return new global::AcidSharp.Maths(native, skipVTables);
        }

        private static void* __CopyValue(global::AcidSharp.Maths.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AcidSharp.Maths.__Internal));
            *(global::AcidSharp.Maths.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Maths(global::AcidSharp.Maths.__Internal native, bool skipVTables = false)
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

        public Maths()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AcidSharp.Maths.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Maths(global::AcidSharp.Maths _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AcidSharp.Maths.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AcidSharp.Maths.__Internal*) __Instance) = *((global::AcidSharp.Maths.__Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AcidSharp.Maths __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>Generates a random value from between a range.</summary>
        /// <param name="min">The min value.</param>
        /// <param name="max">The max value.</param>
        public static float Random(float min, float max)
        {
            var __arg0 = &min;
            var __arg1 = &max;
            var __ret = __Internal.Random(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Generates a single value from a normal distribution, using Box-Muller. https://en.wikipedia.org/wiki/Box%E2%80%93Muller_transform</summary>
        /// <param name="standardDeviation">The standards deviation of the distribution.</param>
        /// <param name="mean">The mean of the distribution.</param>
        public static float RandomNormal(float standardDeviation, float mean)
        {
            var __arg0 = &standardDeviation;
            var __arg1 = &mean;
            var __ret = __Internal.RandomNormal(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Creates a number between two numbers, logarithmic.</summary>
        /// <param name="min">The min value.</param>
        /// <param name="max">The max value.</param>
        public static float RandomLog(float min, float max)
        {
            var __arg0 = &min;
            var __arg1 = &max;
            var __ret = __Internal.RandomLog(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Converts degrees to radians.</summary>
        /// <param name="degrees">The degrees value.</param>
        public static float Radians(float degrees)
        {
            var __arg0 = &degrees;
            var __ret = __Internal.Radians(__arg0);
            return __ret;
        }

        /// <summary>Converts radians to degrees.</summary>
        /// <param name="radians">The radians value.</param>
        public static float Degrees(float radians)
        {
            var __arg0 = &radians;
            var __ret = __Internal.Degrees(__arg0);
            return __ret;
        }

        /// <summary>Normalizes a angle into the range of 0-360.</summary>
        /// <param name="degrees">The source angle.</param>
        public static float WrapDegrees(float degrees)
        {
            var __arg0 = &degrees;
            var __ret = __Internal.WrapDegrees(__arg0);
            return __ret;
        }

        /// <summary>Normalizes a angle into the range of 0-2PI.</summary>
        /// <param name="radians">The source angle.</param>
        public static float WrapRadians(float radians)
        {
            var __arg0 = &radians;
            var __ret = __Internal.WrapRadians(__arg0);
            return __ret;
        }

        /// <summary>Rounds a value to a amount of places after the decimal point.</summary>
        /// <param name="value">The value to round.</param>
        /// <param name="place">How many places after the decimal to round to.</param>
        public static float RoundToPlace(float value, int place)
        {
            var __arg0 = &value;
            var __arg1 = &place;
            var __ret = __Internal.RoundToPlace(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Used to floor the value if less than the min.</summary>
        /// <param name="min">The minimum value.</param>
        /// <param name="value">The value.</param>
        public static float Deadband(float min, float value)
        {
            var __arg0 = &min;
            var __arg1 = &value;
            var __ret = __Internal.Deadband(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Checks if two values are almost equal.</summary>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        /// <param name="eps">EPS is the measure of equality.</param>
        public static bool AlmostEqual(float a, float b, float eps)
        {
            var __arg0 = &a;
            var __arg1 = &b;
            var __arg2 = &eps;
            var __ret = __Internal.AlmostEqual(__arg0, __arg1, __arg2);
            return __ret;
        }

        /// <summary>Gradually changes a value to a target.</summary>
        /// <param name="current">The current value.</param>
        /// <param name="target">The target value.</param>
        /// <param name="rate">The rate to go from current to the target.</param>
        public static float SmoothDamp(float current, float target, float rate)
        {
            var __arg0 = &current;
            var __arg1 = &target;
            var __arg2 = &rate;
            var __ret = __Internal.SmoothDamp(__arg0, __arg1, __arg2);
            return __ret;
        }

        /// <summary>Lerps two values by a factor.</summary>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        /// <param name="factor">The factor value.</param>
        public static float Lerp(float a, float b, float factor)
        {
            var __arg0 = &a;
            var __arg1 = &b;
            var __arg2 = &factor;
            var __ret = __Internal.Lerp(__arg0, __arg1, __arg2);
            return __ret;
        }

        /// <summary>Interpolates two values by a factor using linear interpolation.</summary>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        /// <param name="blend">The blend value.</param>
        public static float Interpolate(float a, float b, float blend)
        {
            var __arg0 = &a;
            var __arg1 = &b;
            var __arg2 = &blend;
            var __ret = __Internal.Interpolate(__arg0, __arg1, __arg2);
            return __ret;
        }

        /// <summary>Interpolates two values by a factor using cosine interpolation.</summary>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        /// <param name="blend">The blend value.</param>
        public static float InterpolateCosine(float a, float b, float blend)
        {
            var __arg0 = &a;
            var __arg1 = &b;
            var __arg2 = &blend;
            var __ret = __Internal.InterpolateCosine(__arg0, __arg1, __arg2);
            return __ret;
        }

        /// <summary>A calculation that steps smoothly between two edges.</summary>
        /// <param name="edge0">The inner edge.</param>
        /// <param name="edge1">The outer edge.</param>
        /// <param name="x">The sample.</param>
        public static float SmoothlyStep(float edge0, float edge1, float x)
        {
            var __arg0 = &edge0;
            var __arg1 = &edge1;
            var __arg2 = &x;
            var __ret = __Internal.SmoothlyStep(__arg0, __arg1, __arg2);
            return __ret;
        }
    }

    public unsafe partial class Maths
    {
        public partial struct __Internal
        {
        }

        public static float Pi
        {
            get
            {
                var __ptr = (float*)CppSharp.SymbolResolver.ResolveSymbol("Acid", "?PI@acid@@3MB");
                return *__ptr;
            }
        }

        public static float DegToRad
        {
            get
            {
                var __ptr = (float*)CppSharp.SymbolResolver.ResolveSymbol("Acid", "?DEG_TO_RAD@acid@@3MB");
                return *__ptr;
            }
        }

        public static float RadToDeg
        {
            get
            {
                var __ptr = (float*)CppSharp.SymbolResolver.ResolveSymbol("Acid", "?RAD_TO_DEG@acid@@3MB");
                return *__ptr;
            }
        }
    }
}
