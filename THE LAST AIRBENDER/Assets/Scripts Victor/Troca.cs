using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Troca : MonoBehaviour {

    public static bool trocou;
    public Button botao;

	// Use this for initialization
	void Start () {
        trocou = false;
	}
	
	// Update is called once per frame
	void Update () {
	 
	}

    public void Ativar() {
        trocou = !trocou;
        StartCoroutine(Botao());
    }

    public IEnumerator Botao() {
        botao.interactable = false;
        yield return new WaitForSeconds(5f);
        botao.interactable = true;
    }
}
