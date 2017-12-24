using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JPhysics{
	public interface IPhysics{
		void GetPointByShotParamaters(Vector3 targetPosition, float sideSpin, float topBackSpin);
	}
}
