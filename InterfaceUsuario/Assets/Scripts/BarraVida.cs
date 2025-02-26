using UnityEngine;
using UnityEngine.UI; // Importa o namespace UnityEngine.UI, que cont�m funcionalidades para interface do usu�rio (UI).

public class BarraVida : MonoBehaviour
{

    // Vari�vel p�blica que armazena o valor da vida, variando de 0 a 100.
    public float Vida; // valor de 0 e 100
    // Refer�ncia p�blica para um componente de imagem (UI) que representa a barra de vida.
    public Image Barra;

    private void Start()
    {
        
    }

    private void Update()
    {
        // M�todo Update � chamado uma vez por frame, ideal para atualiza��es cont�nuas.
        // Aqui, a barra de vida � atualizada constantemente com base no valor da vari�vel "Vida".
        //Ser� atualizado todo o momento do jogo
        Barra.fillAmount = Vida / 100;
        // Atualiza a propriedade "fillAmount" da imagem da barra de vida.
        // "fillAmount" varia de 0 a 1, ent�o dividimos "Vida" por 100 para normalizar o valor.
        // Exemplo: Se Vida = 50, fillAmount = 0.5 (metade da barra preenchida).
    }
}
