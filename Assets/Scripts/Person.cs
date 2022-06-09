using System.Collections;
using System.Collections.Generic;
using System;
public class Person 
{
  protected string name;
  public String getName(){
    return name;
  }
  protected string surname;
  protected int age;
  protected DateTime bornYear;
  protected bool isMarried;
  private List<Child> childs;
  
  public List<Child> getChilds(){
    return childs;
  }

//dummy person oluşturma
  public Person(){

    name = "";
    surname = "";
    age = -1;
    bornYear = DateTime.Now;
    isMarried = false;
    childs = null;

  }

  public Person(string name,
                string surname,
                int age,
                DateTime bornYear,
                bool isMarried){

    this.name = name;
    this.surname = surname;
    this.age = age;
    this.bornYear = bornYear;
    this.isMarried = isMarried;

  }

  public Person(string name,
                string surname,
                int age,
                DateTime bornYear,
                bool isMarried,
                List<Child> childs){

    //#TODO merge 24th line of person and this person by something, make it more compact and less eye damaging

    this.name = name;
    this.surname = surname;
    this.age = age;
    this.bornYear = bornYear;
    this.isMarried = isMarried;
    this.childs = childs;

  }

}

public class Child : Person
{

  //dummy child oluşturma
  public Child(): base(){}

  //direkt person sınıfındaki constructor çağrıldı.
  public Child(string name,
               string surname,
               int age,
               DateTime bornYear,
               bool isMarried): base(name,surname,age,bornYear,isMarried){}

  //tüm farklı tipteki özellikleri aynı anda çıkarmak için Tuple yapısını kullandık
  public Tuple<string, string, int, DateTime, bool> showAttributes(){

    return new Tuple<string, string, int, DateTime, bool>(name, surname, age, bornYear, isMarried);

  }  

}
