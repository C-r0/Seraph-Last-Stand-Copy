using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour
{
    // Variaveis
    public float spd; // Variavel spd (float, publica)
    private Vector3 fRight; // Variavel fRight (Vector3, privada)
    private Vector3 fLeft; // Variavel fLeft (Vector3, privada)


    // Start is called before the first frame update
    void Start()
    {
        fRight = transform.localScale; // Determina que o Vector3 é para escala
        fLeft = transform.localScale; // Determina que o Vector3 é para escala
        fLeft.x = fLeft.x * -1; // Multiplica o x por -1 (oque deixa o numero negativo)
    }

    // Update is called once per frame
    void Update()
    {
        Mov(); // Chama o void Mov
    }

    void Mov() 
    {
        // Movimentação
        float hspd = Input.GetAxis("Horizontal"); // Atribui o input horizontal a variavel hspd
        Vector3  mov = new Vector3 (hspd, 0, 0); // Atribui a variavel hspd no eixo X do Vector3 mov
        transform.position += mov * spd * Time.deltaTime; // Muda a posição do personagem de acordo com a variavel mov * spd * Time.deltaTime

        // Olhar Direita / Esquerda
        if (hspd > 0); // Verifica se a variavel hspd é maior que 0
        { 
            transform.localScale = fRight; // Vira o player para a direita
        }
        if (hspd < 0) ; // Verifica se a variavel hspd é menor que 0
        {
            transform.localScale = fLeft; // Vira o player para a esquerda 
        }
    }
}
