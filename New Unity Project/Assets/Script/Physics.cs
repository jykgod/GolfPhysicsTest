using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JPhysics{
	public class Physics : IPhysics{
        private Vector3 targetPosition;
        private float sideSpin;
        private float topBackSpin;
        /**
         * 预处理轨迹线缓存一些参数
         */
        private void PrepareGetPoints(Vector3 startPosition, Vector3 targetPosition, float sideSpin, float topBackSpin){
            if(this.targetPosition == targetPosition && this.sideSpin == sideSpin && this.topBackSpin == topBackSpin){
                return;
            }
            this.targetPosition = targetPosition;
            this.sideSpin = sideSpin;
            this.topBackSpin = topBackSpin;
            Vector3 d = targetPosition - startPosition;
        }
		public void GetPointByShotParamaters(Vector3 startPosition, Vector3 targetPosition, float sideSpin, float topBackSpin){
            PrepareGetPoints(targetPosition, sideSpin, topBackSpin);
        }
	}
}
