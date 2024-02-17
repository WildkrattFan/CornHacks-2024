<<<<<<< HEAD:Cornhacks2024/die.java
package Cornhacks2024;

public class dice {
    private String name;
    private int numSides;

    public dice(String name, int numSides) {
        this.name = name;
=======
public class dice{
    private String diceName;
    private String diceType;
    private String diceDifficulty;
    private int numSides;
    
    public dice(String diceName, int numSides, String diceType, String diceDifficulty){
        this.diceName = diceName;
>>>>>>> d596d078256fa7527e483613f1ee44a8cc882ca8:Cornhacks 2024/die.java
        this.numSides = numSides;
        this.diceType = diceType;
        this.diceDifficulty = diceDifficulty;
    }
<<<<<<< HEAD:Cornhacks2024/die.java

    public getName(){
        return this.name;s
=======
    public getDiceName(){
        return this.diceNamea;
>>>>>>> d596d078256fa7527e483613f1ee44a8cc882ca8:Cornhacks 2024/die.java
    }

    public getNumSides(){
        return this.numSides;
    }
<<<<<<< HEAD:Cornhacks2024/die.java

    public void setName(String name) {
        this.name = name;
=======
    public getDiceType(){
        return this.diceType;
    }
    public getDiceDifficulty(){
        return this.diceDifficulty;
    }
    public void setName(String diceNameame){
        this.diceName = diceName;
>>>>>>> d596d078256fa7527e483613f1ee44a8cc882ca8:Cornhacks 2024/die.java
    }

    public void setNumSides(int numSides) {
        this.numSides = numSides;
    }
<<<<<<< HEAD:Cornhacks2024/die.java

=======
    public void setDiceType(String diceType){
        this.diceType = diceType;
    }
    public void setDiceDifficulty(String diceDifficulty){
        this.diceDifficulty = diceDifficulty;
    }
>>>>>>> d596d078256fa7527e483613f1ee44a8cc882ca8:Cornhacks 2024/die.java
    public toString toString(){
        return ("Name: " + this.diceName + " NumSides: " + this.numSide + " Type: " + this.diceType + " Difficulty: " + this.dice)

    }

}