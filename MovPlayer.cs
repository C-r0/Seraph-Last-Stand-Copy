using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour
{
    // Variaveis.
    public float spd; // Variavel spd (float, publica)
    private Vector3 fRight; // Variavel fRight (Vector3, privada)
    private Vector3 fLeft; // Variavel fLeft (Vector3, privada)


    void Start() // Executado ao iniciar o jogo
    {
        fRight = new Vector3(1, 1, 1); // Determina que a variavel fRight tera um Vector3 de (1, 1, 1)
        fLeft = new Vector3(-1, 1, 1); // Determina que a variavel fLeft tera um Vector3 de (-1, 1, 1)
    }

    void Update() // Executado a cada frame
    {
        Mov(); // Chama o void Mov
    }

    void Mov() // Void para Movimentação
    {
        // Movimentação
        float hspd = Input.GetAxis("Horizontal"); // Atribui o input horizontal a variavel hspd
        Vector3  mov = new Vector3 (hspd, 0, 0); // Atribui a variavel hspd no eixo X do Vector3 mov
        transform.position += mov * spd * Time.deltaTime; // Muda a posição do personagem de acordo com a variavel mov * spd * Time.deltaTime

        // Olhar Direita / Esquerda
        if (hspd > 0) // Verifica se a variavel hspd é maior que 0
        {
            transform.localScale = fRight; // Transforma os valores da escala para a variavel fRight
        }
        if (hspd < 0) // Verifica se a variavel hspd é menor que 0
        {
            transform.localScale = fLeft; // Transforma os valores da escala para a variavel fLeft
        }
    }
}
