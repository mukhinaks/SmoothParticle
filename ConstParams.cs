
using Fusion.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SmoothParticle
{
	[StructLayout(LayoutKind.Explicit)]
	public struct ConstCameraParams {

		[FieldOffset(  0)] public Matrix	World;
		[FieldOffset( 64)] public Matrix	View;
		[FieldOffset(128)] public Matrix	Projection;
		[FieldOffset(192)] public Vector4	ViewPos;
	}
	
	//[StructLayout(LayoutKind.Explicit)]
	//public struct ConstTimerParams {

	//	[FieldOffset(  0)] public float	ElapsedSeconds;

	//}

	[StructLayout(LayoutKind.Explicit)]
	public struct ConstBoundaryParams {
		
		[FieldOffset(  0)] public float	MinX;
		[FieldOffset(  4)] public float	MaxX;
		[FieldOffset(  8)] public float	MinZ;
		[FieldOffset( 12)] public float	MaxZ;
		[FieldOffset( 16)] public float	MinY;
		[FieldOffset( 20)] public float	MaxY;
		[FieldOffset( 24)] public float	ElapsedSeconds;
		[FieldOffset( 28)] public float	Something;

	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ConstFluidParams {

		// FLUID COMMON
		[FieldOffset(  0)] public Vector3	Gravity;
		[FieldOffset( 12)] public float		Temperature;
		[FieldOffset( 16)] public float		Pressure;

		// FLUID INDIVIDUAL
		[FieldOffset( 20)] public float	Density;
		[FieldOffset( 24)] public float	Mass;
		[FieldOffset( 28)] public float	BuoyancyDiffusion;
		[FieldOffset( 32)] public float	Viscosity;
		[FieldOffset( 36)] public float	SurfaceTension;
		[FieldOffset( 40)] public float	Threshold;
		[FieldOffset( 44)] public float	GasStiffness;
		[FieldOffset( 48)] public float	Restitution;
		[FieldOffset( 52)] public float	SupportRadius;
		[FieldOffset( 56 )]
		public Vector2	ElapsedSeconds;

	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ConstParticleParams {
		[FieldOffset(  0)] public Vector4	ColorStable;
		[FieldOffset( 16)] public Vector4	ColorUnstable;
		[FieldOffset( 32)] public int		Max;
		[FieldOffset( 36)] public float		Size;
		[FieldOffset( 40 )]
		public Vector2	ElapsedSeconds;

	}
}
