# Практическая работа №2
## О программе
У нас есть Строитель, который может существовать в единственном виде (паттерн Одиночка). Далее идёт метод постройки здания, включающий в себя несколько подметодов. Для того, чтобы не вызывать каждый метод вручную - создаётся метод, который вызывает их всех разом (паттерн Фасад). Также существуют рабочие, выполняющие определённый вид работ (монтаж, покраска), но при этом имеют общие этапы работ. Чтобы сохранить все этапы, но оставить возможность их изменения для каждого рабочего - создаётся общий для всех рабочих шаблон (паттерн Шаблонный метод).
## Одиночка
Singleton — порождающий шаблон проектирования, гарантирующий, что в однопоточном приложении будет единственный экземпляр некоторого класса, и предоставляющий глобальную точку доступа к этому экземпляру.
## Фасад
Facade — структурный шаблон проектирования, позволяющий скрыть сложность системы путём сведения всех возможных внешних вызовов к одному объекту, делегирующему их соответствующим объектам системы.
## Шаблонный метод
Template Method — описывает скелет алгоритма, перекладывая ответственность за некоторые его шаги на подклассы. Паттерн позволяет подклассам переопределять шаги алгоритма, не меняя его общей структуры.
## UML программы
```plantuml
@startuml

skin rose

title Classes - Class Diagram


class Agregator {
  +Advertisement[] Advertisement_list
  -Filter()
  +Search()
  +offer()
  +Add_Announcement()
  -Checking_Answers()
  +Online_Application()
}

class Advertisement{
  +string Name
  +int price
  +string description
  +real_estate real_estate
  +Advertisement[] Advertisement_list
  +real_estate()
  +Create_Announcement()
  +landlord()
}

class real_estate{
 +String Type
 +Int square_footage
}


class offer{
  +Advertisement Advertisement
  +real_estate real_estate
  +int number
  -Renter()
  +Online_Application()
}


real_estate <-> Advertisement 
Advertisement -> Agregator
Advertisement -> offer
offer <-> Agregator
@enduml
```

