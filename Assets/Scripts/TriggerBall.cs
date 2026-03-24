using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TriggerBall : MonoBehaviour
{
    public Rigidbody rigidBody;
    public Material material;
    private float radius = 1.0f;
    //GetComponent<randomInt>

    void OnCollisionEnter(Collision other) //срабатывает триггер
    {
        Ball otherBall = other.gameObject.GetComponent<Ball>();
        if (otherBall == null)                      //если шар сталкивается со стенкой, то останавливается код
        {
            return;
        }

        //Debug.Log("жопа");
        //если цвет одинаковый уничтожаются
        if (GetComponent<Ball>().color == other.gameObject.GetComponent<Ball>().color) 
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else
        {
            GetComponent<Ball>().StopMove();                            //иначе остановка
            return;
        }
        List<Collider> toChek = new List<Collider>();
        List<Collider> Destroy = new List<Collider>();
        
   }

    private List<Collider> CheckForDestroy(Vector3 explosionPosition)
    {
        List<Collider> result = new List<Collider>();
        // Центр сферы — текущая позиция объекта
        //Vector3 explosionPosition = transform.position;
        // Получаем массив объектов, находящихся в радиусе
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);
        // Обрабатываем найденные объекты
        foreach (Collider hit in colliders)
        {
            Ball myBall = GetComponent<Ball> ();
            Ball hitBall = hit.gameObject.GetComponent<Ball>();
            //Debug.Log("Обнаружен объект: " + hit.name);
            // если цвет объектов одинаковый, удаляются
            if ((hitBall != null) && (myBall.color == hitBall.color))
            {
                result.Add(hit);
            }
            
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
