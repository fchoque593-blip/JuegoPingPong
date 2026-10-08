using UnityEngine;
using UnityEngine.SceneManagement;

public class OpcionesMenu : MonoBehaviour
{
    public void VamosAJugar()
    {
        SceneManager.LoadScene(1);
    }

    public void Salir()
    {
        Application.Quit();
    }
}