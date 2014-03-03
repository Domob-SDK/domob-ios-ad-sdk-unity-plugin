using UnityEngine;
using System.Collections;

public class DomobUnityDemo : MonoBehaviour {
	static string ONLINE_PUBLISHER_ID = "56OJyM1ouMGoULfJaL";
	static string ONLINE_PLACEMENT_ID = "16TLwebvAchkAY6iOMd734jz";
	static string DOMOB_INTERSTITIAL = "Interstitial";
	static string BANNER = "banner";
	string labelString = "Click The Button";

	// Use this for initialization
	void Start () {
		
		//do what you want
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI () {
		float x = 0.25f * Screen.width;
		float padding = 0.077f * Screen.height;
		float w = 0.5f * Screen.width;
		float h = 0.077f * Screen.height;
		
		GUI.Label (new Rect(x, padding * 11, w, h), labelString);
		
        if (GUI.Button(new Rect(x, padding, w, h), "Show BannerAd")) {
			labelString = "WAITING......";
			DMUnityManager.DomobAddBannerADView(0,0,320,50,ONLINE_PUBLISHER_ID,ONLINE_PLACEMENT_ID,"Main Camera",BANNER);
        }
		
		if (GUI.Button(new Rect(x, padding * 3, w, h), "Remove BannerAd")) {
			labelString = "WAITING......";
			DMUnityManager.DomobRemoveBannerADView(BANNER);
        }
		
		if (GUI.Button(new Rect(x, padding * 5, w, h), "Request Interstitial Ad")) {
			labelString = "WAITING......";
			
			DMUnityManager.DomobInterstitialsAdInitialize(ONLINE_PUBLISHER_ID,ONLINE_PLACEMENT_ID,"Main Camera",DOMOB_INTERSTITIAL);
        }
		
		if (GUI.Button(new Rect(x, padding * 7, w, h), "present Interstitial Ad")) {
			labelString = "WAITING......";
			
			DMUnityManager.DomobPresentInterstitialsAd(DOMOB_INTERSTITIAL);
		
        }
		
		if (GUI.Button(new Rect(x, padding * 9, w, h), "Remove nterstitial Ad")) {
			labelString = "WAITING......";
			DMUnityManager.DomobRemoveInterstitialsAd(DOMOB_INTERSTITIAL);
        }
	}
	
	// delegate method
	public void DMAdViewSuccessToLoadAd() {
		labelString = "DMAdViewSuccessToLoadAd";
	}
	
	public void DMWillPresentModalViewFromAd() {
		labelString = "DMWillPresentModalViewFromAd";
	
	}
	
	public void DMAdViewFailToLoadAd(string info) {
		string[] infoStrings = info.Split(',');
		labelString = "DMOfferWallDidFailLoadWithError. ErrorCode:" + infoStrings[0] + ", ErrorContent:" + infoStrings[1];
	}
	
	public void DMDidDismissModalViewFromAd() {
		labelString = "DMDidDismissModalViewFromAd";
	}
	
	public void DMApplicationWillEnterBackgroundFromAd() {
		labelString = "DMApplicationWillEnterBackgroundFromAd";
	}
	
	public void DMInterstitialSuccessToLoadAd() {
		
		labelString = "DMInterstitialSuccessToLoadAd";
	}
	
	public void DMInterstitialFailToLoadAd(string info) {
		string[] infoStrings = info.Split(',');
		labelString = "DMInterstitialFailToLoadAd. ErrorCode:" + infoStrings[0] + ", ErrorContent:" + infoStrings[1];
	}
	
	public void DMInterstitialWillPresentScreen() {
		
		labelString = "DMInterstitialWillPresentScreen";
	}
	
	public void DMInterstitialDidDismissScreen() {
		
		labelString = "DMInterstitialDidDismissScreen";
	}
	public void DMInterstitialWillPresentModalView() {
		
		labelString = "DMInterstitialWillPresentModalView";
	}
	public void DMInterstitialDidDismissModalView() {
		
		labelString = "DMInterstitialDidDismissModalView";
	}
	
	public void DMInterstitialApplicationWillEnterBackground() {
			labelString = "DMInterstitialApplicationWillEnterBackground";
	}
	
	
}
