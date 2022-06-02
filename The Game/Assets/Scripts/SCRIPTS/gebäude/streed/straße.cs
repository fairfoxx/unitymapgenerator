using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class straße : MonoBehaviour
{
    public static straße singleton { set; get; }
    // strasse
    public Transform Straße_licht;
    public Transform Straße_passtnicht;
    public Transform StraßeKurve;
    public Transform Straßesplit;
    public Transform StraßeKreuzung;
    public Transform Straße_idel;
    private CameraControlsAktion cameraActions;
    private Bauen BuildingsystemsAktions;
    private InputAction movement;
    private Transform cameraTransform;

    [SerializeField] Transform b;

    //last 
    private Vector3 last_pos = Vector2.right;

    private int X = 0;
    private int Y = 0;

    Vector3 World_pos;
    private void Awake()
    {
        singleton = this;
        cameraActions = new CameraControlsAktion();
       
    }
   
  
 

    private void Update()
    {

    }
    public void Straße_setzen(Grid_opjekt Objekt, int X, int Y)
    {
       
        if (Map.Map_Rohstoffe[X, Y] >= 1700 && Map.Map_Rohstoffe[X, Y] < 1800 )   // ? # ?
        {                           //   ?
            Objekt.Building_placed = true;
            Strasse_licht(Objekt, 90);

            int x2 = 0, y2 = 0, x = 0, y = 0;
            if (Map.Map_Rohstoffe[X - 1, Y] >= 1700 && Map.Map_Rohstoffe[X - 1, Y] < 1800)
            {
                x2 = 1;
            }
            if (Map.Map_Rohstoffe[X + 1, Y] >= 1700 && Map.Map_Rohstoffe[X + 1, Y] < 1800)
            {
                x = 1;
            }
            if (Map.Map_Rohstoffe[X, Y - 1] >= 1700 && Map.Map_Rohstoffe[X, Y - 1] < 1800)
            {
                y2 = 1;
            }
            if (Map.Map_Rohstoffe[X, Y + 1] >= 1700 && Map.Map_Rohstoffe[X, Y + 1] < 1800)
            {
                y = 1;
            }
            int sum = x + y + x2 + y2;
            if (sum == 4)
            {
                Strasse_Kreuzung(Objekt, 90);
            }
            if (sum == 3)
            {
                if (x == 1 && x2 == 1 && y == 1)
                {
                    Strasse_split(Objekt, 0);
                }
                if (x == 1 && y2 == 1 && y == 1)
                {
                    Strasse_split(Objekt, 90);
                }
                if (x == 1 && x2 == 1 && y2 == 1)
                {
                    Strasse_split(Objekt, 180);
                }
                if (y2 == 1 && x2 == 1 && y == 1)
                {
                    Strasse_split(Objekt, 270);
                }
            }
            if (sum == 2)
            {
                if (x == 1 && x2 == 1)
                {
                    Strasse_licht(Objekt, 0);
                }
                if (y == 1 && y2 == 1)
                {
                    Strasse_licht(Objekt, 90);
                }
                if (y == 1 && x2 == 1)
                {
                    Strasse_Kurve(Objekt, 90);
                }
                if (y == 1 && x == 1)
                {
                    Strasse_Kurve(Objekt, 180);
                }
                if (y2 == 1 && x2 == 1)
                {
                    Strasse_Kurve(Objekt, 0);
                }
                if (y2 == 1 && x == 1)
                {
                    Strasse_Kurve(Objekt, 270);
                }
            }
            if (sum <= 1)
            {
                if (x == 1 | x2 == 1)
                {
                    Strasse_licht(Objekt, 0);
                }
                if (y == 1 | y2 == 1)
                {
                    Strasse_licht(Objekt, 90);
                }
            }
            
        }


        

    }
    private void Strasse_licht(Grid_opjekt Objekt, int winkel)
    {
      Objekt.streed = Straße_licht;
        

        Objekt.Setrotation(winkel);
    }
    private void Strasse_Kurve(Grid_opjekt Objekt, int winkel)
    {
   
            Objekt.streed = StraßeKurve;
        


        Objekt.Setrotation(winkel);
    }
    private void Strasse_Kreuzung(Grid_opjekt Objekt, int winkel)
    {
      
            Objekt.streed = StraßeKreuzung;
      
      

        Objekt.Setrotation(winkel);
    }
    private void Strasse_split(Grid_opjekt Objekt, int winkel)
    {
  
            Objekt.streed = Straßesplit;
       
        
     

        Objekt.Setrotation(winkel);
    }
    private void Strasse_ende(Grid_opjekt Objekt, int winkel)
    {
    
            Objekt.streed = Straße_licht;
    

        Objekt.Setrotation(winkel);
    }
}