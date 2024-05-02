using Meta.WitAi.TTS.Data;
using Meta.XR.MRUtilityKit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class SceneTesting : MonoBehaviour
{
    public GameObject PrefabObject;
    public GameObject TestObject;
    private Vector3 RandomPos;
    private OVRHand RightHand;

    private void Start()
    {

    }


    private void Update()
    {
        
    }

    public void RoomUnderstanding()
    {
       RandomPos = (Vector3) MRUK.Instance.GetCurrentRoom().GenerateRandomPositionInRoom(0.5f, false);
       //Instantiate(PrefabObject, RandomPos, Quaternion.identity);

       MRUK.Instance.GetCurrentRoom().GenerateRandomPositionOnSurface(MRUK.SurfaceType.FACING_UP, 0.05f, new LabelFilter(), out Vector3 SpawnPoint, out Vector3 UpwardPosition);
       //Instantiate(TestObject, SpawnPoint, Quaternion.identity);

       MRUK.Instance.GetCurrentRoom().TryGetClosestSurfacePosition(ProvideCameraPosition(), out Vector3 tPos, out MRUKAnchor closestAnchor);
       //Instantiate(TestObject, tPos , Quaternion.identity);

       MRUK.Instance.GetCurrentRoom().TryGetClosestSeatPose(GetRightControllerRay(), out Pose seatPose, out MRUKAnchor couch);
       //Instantiate(PrefabObject, seatPose.position, Quaternion.identity);
    }

    Ray GetRightControllerRay()
    {
        Vector3 rayOrigin = OVRManager.instance.GetComponent<OVRCameraRig>().rightControllerAnchor.position;
        Vector3 rayDirection = OVRManager.instance.GetComponent<OVRCameraRig>().rightControllerAnchor.forward;
        return new Ray(rayOrigin, rayDirection);
    }

    Ray GetRightcontrollerRay()
    {
        Vector3 rayOrigin = RightHand.transform.position; 
        Vector3 rayDirection = RightHand.transform.forward;
        return new Ray(rayOrigin, rayDirection);
    }

    Vector3 ProvideCameraPosition()
    {
       return OVRManager.instance.GetComponent<OVRCameraRig>().centerEyeAnchor.transform.position;
    }
}
