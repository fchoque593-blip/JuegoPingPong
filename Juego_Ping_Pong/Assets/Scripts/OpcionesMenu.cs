using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class OpcionesMenu : MonoBehaviour
{
    public TMP_Text textoGanador;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Ganador"))
        {
            string ganador = PlayerPrefs.GetString("Ganador");

            textoGanador.text = "GANADOR: " + ganador;

            // Se muestra una sola vez
            PlayerPrefs.DeleteKey("Ganador");
            PlayerPrefs.Save();
        }
        else
        {
            textoGanador.text = "";
        }
    }

    public void VamosAJugar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Salir()
    {
        Application.Quit();
    }
}