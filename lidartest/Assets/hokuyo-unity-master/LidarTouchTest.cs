using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HKY
{
    public class LidarTouchTest : MonoBehaviour
    {
        URGSensorObjectDetector lidar;
        VirtualTouch vt;

        private void Start()
        {
            lidar = GetComponent<URGSensorObjectDetector>();
            vt = GetComponent<VirtualTouch>();
        }

        private void Update()
        {
            foreach (var obj in lidar.GetObjects())
            {
                //Vector3 screenPos = Camera.main.WorldToScreenPoint(obj.position);
                //vt.ClickAt(screenPos.x, screenPos.y);
                Vector3 worldPos = transform.TransformPoint(obj.position);
                vt.ClickAt(worldPos.x, worldPos.y);
            }
        }
    }

}
