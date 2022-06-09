using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasPanelManager : MonoBehaviour
{
  public GameObject PersonButton;
  public GameObject panel1;
  public Vector2 startPoint; //Listenin başlayacağı yeri belirler, görsel olarak ayarlamalar daha rahat yapılabilir.
  public float space;

  public void InsListOfPersons(List<Person> persons){ //hem person hem de child listelerinin ikisini de alabilir.

    Vector3 tempPosition = startPoint;
    GameObject tempButton = null;

    foreach(Person person in persons){
      
      tempButton = Instantiate(PersonButton, tempPosition, Quaternion.identity, panel1.GetComponent<RectTransform>());
      
      tempButton.GetComponent<CanvasPanelManager>().panel1 = panel1;
      tempButton.GetComponent<CanvasPanelManager>().startPoint = (Vector2)tempPosition - 
                                                                 Vector2.down * PersonButton.GetComponent<RectTransform>().sizeDelta.y;
                                          
      tempButton.GetComponent<CanvasPanelManager>().space = space;

      tempButton.GetComponent<ButtonBehavior>().person = person;
      
      tempButton.transform.GetChild(0).GetComponent<Text>().text = tempButton.GetComponent<ButtonBehavior>().person.getName();  

      //prefabdan buttonun genişliğini alır ve belirli bir aralık ekleyerek butonların hizalı görünmesini sağlar
      //buttonların iç içe geçmesini önler
      tempPosition += new Vector3(PersonButton.GetComponent<RectTransform>().sizeDelta.x / 2 + space, 0, 0);
    
    }
  }

//#TODO you can make it better, merge those two metods
    public void InsListOfChilds(List<Child> childs){

    Vector3 tempPosition = startPoint;
    GameObject tempButton = null;

    foreach(Child child in childs){
      
      tempButton = Instantiate(PersonButton, tempPosition, Quaternion.identity, panel1.GetComponent<RectTransform>());
      
      tempPosition += new Vector3(PersonButton.GetComponent<RectTransform>().sizeDelta.x / 2 + space, 0, 0);
    
    }

  }
}
