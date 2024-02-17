package Cornhacks2024;

import java.util.Random;

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

    public int rollEasyChoice(String args[]) {
        Random input = new random(0, 5);
        return input.nextInt(5);

    }

    @Override
    public int rollMediumChoice(String args[]) {
        Random input = new random(0, 10);
        return input.nextInt(10);
    }

    public int rollHardChoice(String args[]) {
        Random input = new random(0, 15);
        return input.nextInt(15);
    }
}