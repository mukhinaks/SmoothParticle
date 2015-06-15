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
	public struct Particle {
		[FieldOffset(  0)] public Vector3	Position;
		[FieldOffset( 12)] public Vector3	Velocity;
		[FieldOffset( 24)] public Vector3	Acceleration;
		[FieldOffset( 36)] public Vector3	Force;
		[FieldOffset( 48)] public int		ID;
		[FieldOffset( 52)] public float		Density;
		[FieldOffset( 56)] public float		Pressure;
		[FieldOffset( 60)] public Vector3	ForceViscosity;
		[FieldOffset( 72)] public Vector3	ForcePressure;
		[FieldOffset( 84)] public Vector3	Something;
	}
}
