
using Business.Concrete;
using Entities.Concrete;

Person person1=new Person();
person1.FistName = "Engin";
person1.LastName = "Demiroğ";
person1.BirthYear = 1985;
person1.NationalId = 12345678910;


PttManager pttManager=new PttManager(new PersonManager());
pttManager.GiveMask(person1);
