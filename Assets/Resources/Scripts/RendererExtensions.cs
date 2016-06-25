using UnityEngine;
using System.Collections;

public static class RendereExtensions {
	public static bool IsVisibleForm (this Renderer renderer, Camera camera)
	// Use this for initialization
	{
		Plane[] planes = GeometryUtility.CalculateFrustumPlanes (camera);
		return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
	}
}
