using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class Market : MonoBehaviour
{
    // Variaveis
    public GameObject mIcon; // Variavel do icone
    public GameObject mE; // Variavel do botão E
    public Vector3 mEpos; // Variavel da posição do botao E
    public Vector3 mEpose; // Variavel da posição do botão E quando esta fora da cena
    public Vector3 mEscale; // Variavel da escala do botao E

    void Start() // Executa ao iniciar o jogo
    {
        mIcon.SetActive(false); // Desativa o icone
    }

    private void OnTriggerExit2D(Collider2D other) // Ativa quando o player sai de contato com o objeto
    {
        if (other.CompareTag("Player")) // Verifica se é o player
        {
            mIcon.SetActive(false); // Desativa o icone
            mE.transform.position = mEpose; // Troca a posição do mE para a variavel mEpose
        }
    }
    private void OnTriggerEnter2D(Collider2D other) // Ativa quando o player Entra em contato com o objeto
    {
        if (other.CompareTag("Player")) // Verifica se é o player
        {
            mIcon.SetActive(true); // Ativa o icone
            mE.transform.position = mEpos; // Troca a posição do mE para a variavel mEpos
            mE.transform.localScale = mEscale; // Troca a escala do mE para a escala mEscale
        }   
    }
}
