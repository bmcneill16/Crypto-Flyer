using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;



public class AdDisplay : MonoBehaviour, IUnityAdsInitializationListener
{

    public string myGameIdAndroid = "4945086";
    public string myGameIdIOS = "4945087";
    public string myAdUnitIdAndroid = "Interstitial_Android";
    public string myAdUnitIdIOS = "Interstitial_iOS";
    public string myAdUnitId;
    public bool adStarted;
    private bool testMode = true;

    public void OnInitializationComplete()
    {
        throw new System.NotImplementedException();
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        throw new System.NotImplementedException();
    }

    void Start() 
    {
#if UNITY_IOS
            Advertisement.Intialize(myGameIDIOS, testMode);
            myAdUnitId = myAdUnitIdIOS;
#else
        Advertisement.Initialize(myGameIdAndroid, testMode);
            myAdUnitId = myAdUnitIdAndroid;
        #endif
    }

    // Update is called once per frame
    void Update()
    {
        if (Advertisement.isInitialized && !adStarted)
        {
            Advertisement.Load(myAdUnitId);
            Advertisement.Show(myAdUnitId);
            adStarted = true;
        }
        
 
    }
}

