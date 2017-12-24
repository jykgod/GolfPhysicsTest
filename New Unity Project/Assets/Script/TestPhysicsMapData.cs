using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JPhysics{
    public class TestPhysicsMapData : IPhysicsMapData{
        private PhysicMaterial testPhysicMaterial;
        public TestPhysicsMapData(){
            testPhysicMaterial = new PhysicMaterial();
        }
        public float GetHeight(float x, float z){
            return 0;
        }
        public float GetHeight(Vector3 v3){
            return GetHeight(v3.x, v3.z);
        }
        public Vector3 GetNormal(float x, float z){
            return Vector3.up;
        }
        public Vector3 GetNormal(Vector3 v3){
            return GetNormal(v3.x, v3.z);
        }
        public PhysicMaterial GetPhysicsMaterial(float x, float z){
            return new PhysicMaterial();
        }
        public PhysicMaterial GetPhysicsMaterial(Vector3 v3){
            return GetPhysicsMaterial(v3.x, v3.z);
        }
    }
}
