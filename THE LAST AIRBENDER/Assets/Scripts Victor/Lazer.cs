using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lazer : MonoBehaviour {

    [Header("Normal Variables")]
    public Button botao;
    public static bool laser;
    private bool move = false;
    public GameObject mira;

    // Use this for initialization
    void Start () {
        laser = false;
	}

    // Update is called once per frame
    void Update()
    {
        if (laser == true) {
            Vector3 temp = Input.mousePosition;
            temp.z = 10f; // Set this to be the distance you want the object to be placed in front of the camera.
            mira.transform.position = Camera.main.ScreenToWorldPoint(temp);
        }
    }    

    public void botaoPress() {
        laser = true;
        botao.interactable = false;
        StartCoroutine(timing());
    }

    public IEnumerator timing() {
        botao.GetComponent<Animator>().SetTrigger("go");
        yield return new WaitForSeconds(10f);
        botao.GetComponent<Animator>().SetTrigger("back");
        botao.interactable = true;
        laser = false;
    }
}
