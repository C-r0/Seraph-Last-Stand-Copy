using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Market : MonoBehaviour
{
    // Variaveis
    public GameObject mIcon; // Variavel do icone

    void Start() // Executa ao iniciar o jogo
    {
        mIcon.SetActive(false); // Desativa o icone
    }

    void Update() // Executa a cada frame
    {

    }

    void OnTriggerEnter(Collider other) // Ativa quando o player entra em contato com o objeto
    {
        Debug.Log("OnTriggerEnter");
        if (other.CompareTag("Player")) // Compara se o objeto que colidiu é o Player
        {
            mIcon.SetActive(true); // Ativa o icone
        }
    }
    void OnTriggerExit(Collider other) // Ativa quando o player sai do objeto
    {
        Debug.Log("OnTriggerExit");
        if (other.CompareTag("Player")) // Verifica se é o player
        {
            mIcon.SetActive(false); // Desativa o icone
        }   
    }
}
