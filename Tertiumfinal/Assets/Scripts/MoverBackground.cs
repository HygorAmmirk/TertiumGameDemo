using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Unity User Manual - https://docs.unity3d.com/Manual/index.html
//Documenta��o do C# - https://docs.microsoft.com/pt-br/dotnet/csharp/

public class MoverBackground : MonoBehaviour 
{
    public float VelocidadeDaRolagem = 1; // Declara��es de vari�veis.
    public float juncao = 1
       ;
    private Vector3 PosicaoInicial; /* Vector3 -- Representa��o de vetores e pontos 3D.
         Essa estrutura � usada em todo o Unity para passar posi��es e dire��es 3D. Ele tamb�m cont�m fun��es para executar opera��es vetoriais comuns.*/

    void Start()
    {
        PosicaoInicial = transform.position; // = Atribui��o 
    }

    void Update()
    {
        float NovaPosicao = Mathf.Repeat(Time.time * VelocidadeDaRolagem, -juncao);
        transform.position = PosicaoInicial + Vector3.forward * NovaPosicao;
    }
}
