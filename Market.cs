using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Market : MonoBehaviour
{
    // Variaveis
    public GameObject mIcon;

    void Start() // Executa ao iniciar o jogo
    {
        
    }

    void Update() // Executa a cada frame
    {

    }   



    void OnTriggerEnter(Collider other) // Void usado para checar se player esta perto do market
    {
        if (other.CompareTag("Player")) // Compara se o objeto que colidiu é o Player
        {
            mIcon.SetActive(true); // Ativa o icone
        }
        else // Se não estiver colidindo
        {
            mIcon.SetActive(false); // Desativa o icone
        }
    }
}
