using UnityEngine;

public class BikeCollision : MonoBehaviour
    
{
    public GameObject gameManager;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obs"))
        {
            gameManager.GetComponent<GameManager>().gameOverf();
          
        }
    }
}