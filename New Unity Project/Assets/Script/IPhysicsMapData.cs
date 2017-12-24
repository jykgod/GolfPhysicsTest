using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JPhysics{
	public interface IPhysicsMapData{
		float GetHeight(float x, float z);
        Vector3 GetNormal(float x, float z);
        PhysicMaterial GetPhysicsMaterial(float x, float z);
        float GetHeight(Vector3 v3);
        Vector3 GetNormal(Vector3 v3);
        PhysicMaterial GetPhysicsMaterial(Vector3 v3);

	}
}
