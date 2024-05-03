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

    private void OnTriggerExit2D(Collider2D other) // Ativa quando o player sai de contato com o objeto
    {
        if (other.CompareTag("Player")) // Verifica se é o player
        {
            mIcon.SetActive(false); // Desativa o icone
        }
    }
    private void OnTriggerEnter2D(Collider2D other) // Ativa quando o player Entra em contato com o objeto
    {
        if (other.CompareTag("Player")) // Verifica se é o player
        {
            mIcon.SetActive(true); // Ativa o icone
        }   
    }
}
