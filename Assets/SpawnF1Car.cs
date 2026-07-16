using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class SpawnF1Car : MonoBehaviour
{
    public GameObject f1CarPrefab; 
    private ARRaycastManager raycastManager;
    private GameObject spawnedCar;

    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        // 1. Check if the user touched the screen
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            List<ARRaycastHit> hits = new List<ARRaycastHit>();
            
            // 2. Shoot an invisible ray from the touch position into the real world
            if (raycastManager.Raycast(Input.GetTouch(0).position, hits, TrackableType.PlaneWithinPolygon))
            {
                // 3. Get the exact 3D coordinates of where the ray hit the physical table
                Pose hitPose = hits[0].pose;

                // 4. If a car doesn't exist yet, spawn it. If it does, move it to the new tap spot.
                if (spawnedCar == null)
                {
                    spawnedCar = Instantiate(f1CarPrefab, hitPose.position, hitPose.rotation);
                }
                else
                {
                    spawnedCar.transform.position = hitPose.position;
                }
            }
        }
    }
}