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
        Debug.Log("Unity Ads initialization complete.");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    }

    void Start() 
    {
#if UNITY_IOS
            Advertisement.Initialize(myGameIdIOS, testMode, this);
            myAdUnitId = myAdUnitIdIOS;
#else
        Advertisement.Initialize(myGameIdAndroid, testMode, this);
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

