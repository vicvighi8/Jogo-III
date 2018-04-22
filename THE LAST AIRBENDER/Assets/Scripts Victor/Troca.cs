using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Troca : MonoBehaviour
{

    public Image image;

    public AudioClip changeSound1;
    public AudioClip changeSound2;



    public static bool trocou;
    public Button botao;

    // Use this for initialization
    void Start()
    {
        trocou = false;
        image.GetComponent<Image>();
    }

    public void Ativar()
    {
        trocou = !trocou;
        StartCoroutine(Botao());
        image.GetComponent<Image>().color = Color.yellow;
        SoundManagerScript.instance.RandomizeSfx(changeSound1, changeSound2);
    }

    public IEnumerator Botao()
    {
        botao.interactable = false;
        botao.GetComponent<Animator>().SetTrigger("go");
        yield return new WaitForSeconds(5f);
        botao.GetComponent<Animator>().SetTrigger("back");
        botao.interactable = true;
    }  
}
