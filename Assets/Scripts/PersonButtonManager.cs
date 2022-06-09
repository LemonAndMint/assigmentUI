using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PersonButtonManager : MonoBehaviour
{
  public Text desc;
  //yaratılacak button, person ya da child olabilir
  public GameObject ChildButton;
  public GameObject panel1;
  public Vector2 startPoint; //Listenin başlayacağı yeri belirler, görsel olarak ayarlamalar daha rahat yapılabilir.
  //butonlar arası boşluk
  public float space;
    //#TODO you can make it better, merge those two metods
    public void InsListOfChilds(List<Child> childs){

    Vector3 tempPosition = startPoint;
    GameObject tempButton = null;

    foreach(Child child in childs){
      
      tempButton = Instantiate(ChildButton, tempPosition, Quaternion.identity, panel1.GetComponent<RectTransform>());

      tempButton.GetComponent<ShowChildAttributes>().desc = desc;
      tempButton.GetComponent<ShowChildAttributes>().child = child;

      tempButton.transform.GetChild(0).GetComponent<Text>().text = tempButton.GetComponent<ShowChildAttributes>().child.getName();  
      //prefabdan buttonun genişliğini alır ve belirli bir aralık ekleyerek butonların hizalı görünmesini sağlar
      //buttonların iç içe geçmesini önler
      tempPosition += new Vector3(ChildButton.GetComponent<RectTransform>().sizeDelta.x / 2 + space, 0, 0);
    
    }

  }
}
