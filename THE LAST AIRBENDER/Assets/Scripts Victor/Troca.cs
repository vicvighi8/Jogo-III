using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

<<<<<<< HEAD
public class Troca : MonoBehaviour
{

    public Image image;

    public AudioClip changeSound1;
    public AudioClip changeSound2;


=======
public class Troca : MonoBehaviour {
    [Header("Normal Variables")]
>>>>>>> 43e2ddd9e87ec65a67dfcb866ea41a9883bd1977

    public static bool trocou;
    public Button botao;
    public GameObject imgDash;
    public GameObject imgJump;
    private bool inverter = true;

    // Use this for initialization
    void Start()
    {
        trocou = false;
        image.GetComponent<Image>();
    }

    public void Ativar()
    {
        trocou = !trocou;
        if (inverter == true)
        {
            imgDash.GetComponent<Animator>().SetTrigger("go1");
            imgJump.GetComponent<Animator>().SetTrigger("go1");
            inverter = false;
        }
        else {
            imgDash.GetComponent<Animator>().SetTrigger("go2");
            imgJump.GetComponent<Animator>().SetTrigger("go2");
            inverter = true;
        }
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
