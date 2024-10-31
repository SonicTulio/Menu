using UnityEngine;
using UnityEngine.SceneManagement;

public class SpriteClick : MonoBehaviour
{
    void Update()
    {
        // Verifica se o botão do mouse foi clicado
        if (Input.GetMouseButtonDown(0))
        {
            // Cria um raio a partir da posição do mouse
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            // Verifica se o raio atingiu algo
            if (hit.collider != null)
            {
                // Verifica se o objeto clicado é este sprite
                if (hit.collider.gameObject == gameObject)
                {
                    // Carrega a cena "Fase1"
                    SceneManager.LoadScene("Fase1");
                }
            }
        }
    }
}
