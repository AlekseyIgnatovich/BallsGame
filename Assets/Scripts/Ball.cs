using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Color colorRed;
    [SerializeField] private Color colorGreen;
    [SerializeField] private Color colorBlue;
    [SerializeField] private Color colorYellow;
    [SerializeField] private Color colorPurple;
    public int color;
    public float speed = 5f;
   
    void Start()
    {
    }

    public void StartMove(Vector3 direction)
    { 
       GetComponent<Rigidbody>().AddForce(direction * speed *100);
    }

    public void StopMove()                  //метод останавливает шар
    {
        GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
    }
    
    public void SetColor()
    {
       color = UnityEngine.Random.Range(0, 5);                 //метод присваивает шарикам рандомно цвета
        switch (color)
        {
            case 0: 
                SetColorPurple();
                break;
            case 1: 
                SetColorRed();
                break;
            case 2: 
                SetColorGreen();
                break;
            case 3: 
                SetColorBlue();
                break;
            case 4: 
                SetColorYellow();
                break;
        } 
        //Debug.Log(randomInt);
    }
    
    public void SetColorPurple()
    {
        Renderer renderer = gameObject.GetComponent<Renderer>();                    //объявляется ссылка и ей присваивается объект рендер
        renderer.material.color = colorPurple;
    }
    public void SetColorRed()
    {
        Renderer renderer = gameObject.GetComponent<Renderer>();
        renderer.material.color = colorRed;
    }
    public void SetColorGreen()
    {
        Renderer renderer = gameObject.GetComponent<Renderer>();
        renderer.material.color = colorGreen;
    }
    public void SetColorBlue()
    {
        Renderer renderer = gameObject.GetComponent<Renderer>();
        renderer.material.color = colorBlue;
    }
    public void SetColorYellow()
    {
        Renderer renderer = gameObject.GetComponent<Renderer>();
        renderer.material.color = colorYellow;
    }
    
    
    
}

