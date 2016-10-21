using UnityEngine;
using System.Collections;

public class MemoryCard : MonoBehaviour {
    [SerializeField]
    private GameObject cardBack;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnMouseDown()
    {
        if (cardBack.activeSelf)
            cardBack.SetActive(false);
    }
}
