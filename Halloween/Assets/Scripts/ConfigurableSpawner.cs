using UnityEngine;

public class ConfigurableSpawner : MonoBehaviour
{
	// this will show up in Unity's inspector, we can find an asset there
	public GameObject asset;

	void Start()
    {
		// let's instantiate our asset
		GameObject someNewEntity = Instantiate(asset);
		someNewEntity.transform.position = new Vector3(7, 1, -5);
    }
}
