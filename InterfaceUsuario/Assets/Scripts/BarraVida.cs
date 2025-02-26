using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public float Vida; // valor de 0 e 100
    public Image Barra;

    private void Start()
    {
        
    }

    private void Update()
    {
        //Será atualizado todo o momento do jogo
        Barra.fillAmount = Vida / 100;
    }
}
