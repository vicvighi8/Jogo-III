using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lazer : MonoBehaviour {

    [Header("Normal Variables")]
    public Button botao;
    public static bool laser;
    private bool move = false;

    // Use this for initialization
    void Start () {
        laser = false;
	}

    // Update is called once per frame
    void Update()
    {
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
