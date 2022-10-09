using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace HKY
{
    public class TrackedObject : MonoBehaviour
    {
        public ProcessedObject processedObject;
        public System.Guid guid;
        //public Transform transform;

        //private void OnCollisionEnter(Collision collision)
        //{
        //    Debug.Log("Touched an object!: " + collision.gameObject.name);
            
        //    StartCoroutine(FlashCollisionColor());
        //}

        //IEnumerator FlashCollisionColor()
        //{
        //    MeshRenderer mr = GetComponent<MeshRenderer>();
        //    mr.material.color = Color.red;
        //    yield return new WaitForSeconds(5.0f);
        //    mr.material.color = Color.white;
        //}
    }
}

