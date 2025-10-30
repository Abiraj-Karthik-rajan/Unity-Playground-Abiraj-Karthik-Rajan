using UnityEditor;
using UnityEngine;


public class CandleSpawner : MonoBehaviour
{
    void Start()
    {
	    // we take the candle from our assets database
	    // basically we look this up by "path" in the project bin.
	    GameObject candleAsset = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Models/Kenney-Graveyard-Kit/candle.fbx");

	    // here we create an instance of it in the scene
	    GameObject myCandle = Instantiate(candleAsset);

	    // let's put it somewhere where we can actualy see it.
	    myCandle.transform.position = new Vector3(0, 2, 0);
    }
}
