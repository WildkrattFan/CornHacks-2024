package Cornhacks2024;

import java.util.Random;

public class Dice {
    private String diceType;
    private int numSides;
    private String diceDifficulty;
    private Random random;

    public Dice(String diceType, int numSides, String diceDifficulty, Random random) {
        this.numSides = numSides;
        this.diceType = diceType;
        this.diceDifficulty = diceDifficulty;
        this.random = random;
    }

    public String getDiceType() {
        return this.diceType;
    }

    public String getDiceDifficulty() {
        return this.diceDifficulty;
    }

    public int getNumSides() {
        return this.numSides;
    }

    public String toString() {
        return ("Name: " + this.diceType + " NumSides: " + this.numSides + " Type: " + this.diceType + " Difficulty: "
                + this.diceDifficulty);

    }

    public int rollEasyChoice(String args[]) {
        return random.nextInt(5) + 1;

    }

    public int rollMediumChoice(String args[]) {
        return random.nextInt(10) + 1;
    }

    public int rollHardChoice(String args[]) {
        return random.nextInt(15) + 1;
    }

}
