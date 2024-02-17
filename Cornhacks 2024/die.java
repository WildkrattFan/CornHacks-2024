public class dice{
    private String diceName;
    private String diceType;
    private String diceDifficulty;
    private int numSides;
    
    public dice(String diceName, int numSides, String diceType, String diceDifficulty){
        this.diceName = diceName;
        this.numSides = numSides;
        this.diceType = diceType;
        this.diceDifficulty = diceDifficulty;
    }
    public getDiceName(){
        return this.diceNamea;
    }
    public getNumSides(){
        return this.numSides;
    }
    public getDiceType(){
        return this.diceType;
    }
    public getDiceDifficulty(){
        return this.diceDifficulty;
    }
    public void setName(String diceNameame){
        this.diceName = diceName;
    }
    public void setNumSides(int numSides){
        this.numSides = numSides;
    }
    public void setDiceType(String diceType){
        this.diceType = diceType;
    }
    public void setDiceDifficulty(String diceDifficulty){
        this.diceDifficulty = diceDifficulty;
    }
    public toString toString(){
        return ("Name: " + this.diceName + " NumSides: " + this.numSide + " Type: " + this.diceType + " Difficulty: " + this.dice)

    }

}