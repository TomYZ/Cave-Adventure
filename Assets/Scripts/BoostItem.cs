using UnityEngine;
using System.Collections;

public class BoostItem : MonoBehaviour {

    // Use this for initialization
    private Collider2D target;

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D target)
    {
        this.target = target;
        if (target.gameObject.tag == "Player")
        {
            StartCoroutine("ActivateBoost");
            StartCoroutine("DeActivateBoost");
        }
    }
    IEnumerator ActivateBoost()
    {
        target.gameObject.GetComponent<MainController>().isboost = true;
        target.gameObject.GetComponent<MainController>().speed = 20f;
        yield return null;

    }

    IEnumerator DeActivateBoost()
    {
        yield return new WaitForSeconds(2.5f);
        target.gameObject.GetComponent<MainController>().isboost = false;
        target.gameObject.GetComponent<MainController>().speed = 10f;
        Destroy(gameObject);
    }
}
