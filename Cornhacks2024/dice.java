package Cornhacks2024;

public class Dice {
    private String diceType;
    private int numSides;
    private String diceDifficulty;

    public Dice(String diceType, int numSides, String diceDifficulty) {
        this.numSides = numSides;
        this.diceType = diceType;
        this.diceDifficulty = diceDifficulty;
    }

    public String getDiceType() {
        return this.diceType;
    }

    public int getNumSides() {
        return this.numSides;
    }

    public String toString() {
        return ("Name: " + this.diceType + " NumSides: " + this.numSides + " Type: " + this.diceType + " Difficulty: "
                + this.diceDifficulty);

    }

}