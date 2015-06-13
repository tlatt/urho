using System;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.InteropServices;

namespace Urho {
	[StructLayout (LayoutKind.Sequential)]
	public struct Ray {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct IntVector2 {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct Vector2 {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct Vector3 {
	}
	
	[StructLayout (LayoutKind.Sequential)]
	public struct Vector4 {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct IntRect {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct ResourceRef {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct HashIteratorBase {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct Iterator {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct ResourceRefList {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct BoundingBox {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct Quaternion {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct Matrix4 {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct Matrix3x4 {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct Color {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct Frustum {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct Variant {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct XPathResultSet {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct TouchState {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct ColorFrame {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct JoystickState {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct TextureFrame {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct LightBatchQueue {
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct Bone {
	}

	// DEBATABLE: maybe we should let the binder handle it?
	[StructLayout (LayoutKind.Sequential)]
	public struct ReplicationState {
	}

	// DEBATABLE: maybe we should let the binder handle it?
	[StructLayout (LayoutKind.Sequential)]
	public struct NodeReplicationState {
	}

	// DEBATABLE: maybe we should let the binder handle it?
	[StructLayout (LayoutKind.Sequential)]
	public struct RenderPathCommand {
	}
	
	// DEBATABLE: maybe we should let the binder handle it?
	[StructLayout (LayoutKind.Sequential)]
	public struct GPUObject {
	}
	// DEBATABLE: maybe we should let the binder handle it?
	[StructLayout (LayoutKind.Sequential)]
	public struct GraphicsImpl {
	}
	// DEBATABLE: maybe we should let the binder handle it?
	[StructLayout (LayoutKind.Sequential)]
	public struct FontGlyph {
	}
	// DEBATABLE: maybe we should let the binder handle it?
	[StructLayout (LayoutKind.Sequential)]
	public struct RandomAccessIterator {
	}
	// DEBATABLE: maybe we should let the binder handle it?
	[StructLayout (LayoutKind.Sequential)]
	public struct ModelMorph {
	}
	// DEBATABLE: maybe we should let the binder handle it?
	[StructLayout (LayoutKind.Sequential)]
	public struct Octant {
	}
	// DEBATABLE: maybe we should let the binder handle it?
	[StructLayout (LayoutKind.Sequential)]
	public struct CompressedLevel {
	}

	// DEBATABLE: maybe we should let the binder handle it?
	[StructLayout (LayoutKind.Sequential)]
	public struct Billboard {
	}

	// DEBATABLE: maybe we should let the binder handle it?
	[StructLayout (LayoutKind.Sequential)]
	public struct AnimationTrack {
	}

	// DEBATABLE: maybe we should let the binder handle it?
	[StructLayout (LayoutKind.Sequential)]
	public struct CustomGeometryVertex {
	}

	// DEBATABLE: maybe we should let the binder handle it?
	[StructLayout (LayoutKind.Sequential)]
	public struct NetworkState {
	}

	// DEBATABLE: maybe we should let the binder handle it?
	[StructLayout (LayoutKind.Sequential)]
	public struct ComponentReplicationState {
	}

	// DEBATABLE: maybe we should let the binder handle it?
	[StructLayout (LayoutKind.Sequential)]
	public struct ShaderParameter {
	}
}


namespace System {
	//
	// Hacks until I get Sharpie to not mess with my types
	//
	[StructLayout (LayoutKind.Sequential)]
	public struct nuint {
		UIntPtr x;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct nint {
		IntPtr x;
	}

}