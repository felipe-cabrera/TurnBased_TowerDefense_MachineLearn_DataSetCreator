# TurnBased_TowerDefense_MachineLearn_DataSetCreator  
The dataset creator of the project https://github.com/felipe-cabrera/TurnBased_TowerDefense_MachineLearn  

# How To  

## 1. The main class  
  Our main class is "DataSetCreator.cs", here you can:
  - 1.1. Define the amount of data to be created (line 24: int dataSetAmount)  
  - 1.2. Set the generation type, if it's an specifc class dataset or a random one (line 31: EnemyGenerator.Generate())  
  - 1.3. Choose the Classifier (line 37: DefaultClassifier())  
  - 1.4. Convert to JSON (line 41: JsonConvert.SerializeObject())  
  - 1.5. Choose the dataset name (line 44: File.WriteText("name",json));  
  
## 2. Enemy Creator Flow  
  We start on "EnemyGenerator.cs", by calling it on our main class (See 1.2), after we choose the creation type (Random or Specific) we need to get the Rules of the current enemy class (as for example, for a Green Enemy we have Attack and Defense between 11 and 20). After that, we will create an enemy with properties (Attack and Defense) with values in this range. The enemy will be storaged in the main class (see 1) in the list 'Enemies' (line 23: List<Enemy> Enemies)  
 
## 3. Create a new Enemy  
 To do so, first we will need to add a new Enemy in the enum "EnemyTypes.cs", but it's very simple, we only need to add a line with the name of our new enemy class :).  
 After that we need to create a new Rule, for this part we need to go deeper on "EnemyRule.cs" and create a new block of the swith-case code in the method 'ClassRules', like this:  
 ```  
 case EnemyTypes.Red:  
                    AttackInterval = new int[] { 11, 15 };  
                    DefenseInterval = new int[] { 7, 12 };  
                    break;  
```  
 
## 4. Edit a Enemy Rule
 As we learned in the previous item, it's very simple, we only need to go deeper on "EnemyRule.cs" and create a new block of the swith-case code in the method 'ClassRules', like this:  
 ```    
 case EnemyTypes.Red:  
                    AttackInterval = new int[] { 11, 15 };  
                    DefenseInterval = new int[] { 7, 12 };  
                    break;  
```  
 
 ## 5. Create a new Classifier  
  Well... That's the most complicated part, but it's also easy. To create a new Classify we need to create a class that implements the interface IClassifier and develop our algorithm into the method Classify, returning the classified type of our enemy.  
  You can check the class DefaultClassifier to see an example of how to implements the IClassifier interfaces  
  
# Authors:
  Felipe Cabrera Ribeiro dos Santos  
  Mauricio Anderson Perecim  
  Paulo Berlanga Neto  
  Vinícius de Souza Gonçalves  
 
