using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputApi : MonoBehaviour {
    // check here for weather stats
    // https://api.instagram.com

	public string url = "https://api.instagram.com/v1/tags/W_ww/media/recent?access_token=29609891.26124ec.8e4fefb7d548445b986c625b2e111cc7";

    public int photoID;

    IEnumerator Start() {

		// fetch the actual info, like you would from a browser
		WWW www = new WWW(url);

		// yield return waits for the download to complete before proceeding
		// but since this is in IEnumerator it wont stall the program outright
		yield return www;

		// use a JSON Object to store the info temporarily
		// this makes it easy to access the data struture
		JSONObject tempData = new JSONObject (www.text);

		// this particular API stores all the data under the header
		// "consolidated_weather" so first get in there
		JSONObject data= tempData["data"][photoID]["images"];

        Debug.Log(data);


        // now we can do cool stuff like...
        JSONObject jsonURL = data["standard_resolution"]["url"];

        // turn into string
        string imageURL = jsonURL.ToString();

        // get rid of quotes
        imageURL = imageURL.Replace("\"", "");



        Debug.Log (imageURL);

        // ... finally, time for the image! we have a clean URL
        // Start a download of the given URL
        WWW imageWWW = new WWW(imageURL);

        // Wait for download to complete
        yield return imageWWW;

        // assign texture
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = imageWWW.texture;

    }
}
