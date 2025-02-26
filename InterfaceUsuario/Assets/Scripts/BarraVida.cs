using UnityEngine;
using UnityEngine.UI; // Importa o namespace UnityEngine.UI, que contém funcionalidades para interface do usuário (UI).

public class BarraVida : MonoBehaviour
{

    // Variável pública que armazena o valor da vida, variando de 0 a 100.
    public float Vida; // valor de 0 e 100
    // Referência pública para um componente de imagem (UI) que representa a barra de vida.
    public Image Barra;

    private void Start()
    {
        
    }

    private void Update()
    {
        // Método Update é chamado uma vez por frame, ideal para atualizações contínuas.
        // Aqui, a barra de vida é atualizada constantemente com base no valor da variável "Vida".
        //Será atualizado todo o momento do jogo
        Barra.fillAmount = Vida / 100;
        // Atualiza a propriedade "fillAmount" da imagem da barra de vida.
        // "fillAmount" varia de 0 a 1, então dividimos "Vida" por 100 para normalizar o valor.
        // Exemplo: Se Vida = 50, fillAmount = 0.5 (metade da barra preenchida).
    }
}
