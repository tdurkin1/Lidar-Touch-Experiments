using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace HKY
{
    public class SensorTouch : MonoBehaviour
    {

        URGSensorObjectDetector sensor;
        List<ProcessedObject> detectedObjects;
        public List<TrackedObject> trackedObjects = new List<TrackedObject>();
        List<ProcessedObject> curObjs = new List<ProcessedObject>();
        [SerializeField] TrackedObject testObj;
        

        void Start()
        {
            sensor = GetComponent<URGSensorObjectDetector>();
        }


        void Update()
        {
            //working but could be better, no persistence, objects constantly added and destroyed each frame
            detectedObjects = sensor.GetObjects();
            for (int i = 0; i < trackedObjects.Count; i++)
            {
                Destroy(trackedObjects[i].gameObject);
                trackedObjects.Remove(trackedObjects[i]);
            }
            //trackedObjects.Clear();
            foreach (var d in detectedObjects)
            {
                ProcessedObject po = d;
                TrackedObject to = Instantiate(testObj, d.position, Quaternion.identity);
                to.GetComponent<TrackedObject>().guid = po.guid;
                trackedObjects.Add(to);
            }
        }
    }
}

