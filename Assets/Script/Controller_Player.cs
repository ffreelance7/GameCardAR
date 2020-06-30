using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Controller_Player : MonoBehaviour
{
   // public GameObject Parent;
   // private TrackableBehaviour mTrackableBehaviour;
    // Start is called before the first frame update
    void Start()
    {
       /* mTrackableBehaviour = GetComponent<TrackableBehaviour>();

        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }*/
    }
    /* public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
     {
         if (newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
         {
             OnTrackingFound();
         }
         else
         {
             OnTrackingLost();
         }
}
    private void OnTrackingFound()
    {
       /* Debug.Log("Image Target Found!");
        foreach (GameObject o in prefabModels)
        {
            if (o != null)
            {
                Debug.Log("Currently instantiated models is " + o.name);

                GameObject myPrefab = Instantiate(o, Vector3.zero, Quaternion.identity) as GameObject;

                myPrefab.transform.parent = mTrackableBehaviour.transform;
                myPrefab.transform.localPosition = new Vector3(0.0f, 10.0f, 0.0f);
                myPrefab.transform.localRotation = Quaternion.identity;
                //o.transform.localScale = new Vector3(1000.0f, 1000.0f, 1000.0f);

                myPrefab.gameObject.SetActive(true);

            }

        }
    }*/
    // Update is called once per frame
    void Update()
    {
        
    }
}
